// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : ServiceBase.cs
//           description :
// 
//           created by 雪雁 at  2019-11-04 15:18
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Castle.Core.Logging;
using Magicodes.WxMiniProgram.Sdk.AccessToken;
using Newtonsoft.Json;
using RestSharp;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace Magicodes.WxMiniProgram.Sdk.Services
{
    /// <summary>
    ///     接口基类
    /// </summary>
    public abstract class ServiceBase
    {
        /// <summary>
        ///     微信API地址
        /// </summary>
        protected const string BaseApiUrl = "https://api.weixin.qq.com";
        private const string AccessTokenString = "{ACCESS_TOKEN}";

        /// <summary>
        /// 
        /// </summary>
        protected ServiceBase()
        {
            Logger = NullLogger.Instance;
        }

        /// <summary>
        /// 
        /// </summary>
        public IAccessTokenManager AccessTokenManager { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ILogger Logger { get; set; }


        /// <summary>
        ///     接口访问凭据
        /// </summary>
        protected string AccessToken => AccessTokenManager.GetAccessTokenAsync().Result;


        /// <summary>
        ///     配置Key
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="resourceUrl"></param>
        /// <param name="queryParameters"></param>
        /// <returns></returns>
        protected virtual async Task<T> HttpGet<T>(string resourceUrl, Dictionary<string, string> queryParameters = null) where T : ServiceOutputBase, new()
        {
            Logger.Debug($"GET {BaseApiUrl}/{resourceUrl}");
            resourceUrl = SetAccessToken(resourceUrl);
            var client = new RestClient(BaseApiUrl);
            var request = new RestRequest(resourceUrl, Method.GET);
            request.AddHeader("cache-control", "no-cache");
            if (queryParameters != null && queryParameters.Count > 0)
            {
                foreach (var par in queryParameters)
                {
                    request.AddQueryParameter(par.Key, par.Value, true);
                }
            }
            return await ReturnDataAsync<T>(client, request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="resourceUrl"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        protected virtual async Task<T> HttpPost<T>(string resourceUrl, object data = null) where T : ServiceOutputBase, new()
        {
            var client = CreateRestClient(resourceUrl, Method.POST, data, out var request);
            return await ReturnDataAsync<T>(client, request);
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="resourceUrl"></param>
        /// <param name="method"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        protected virtual async Task<byte[]> DownloadData(string resourceUrl, Method method, object data = null)
        {
            var client = CreateRestClient(resourceUrl, method, data, out var request);
            var response = await client.ExecuteTaskAsync(request);
            Logger.Debug($"{response.StatusCode} {response.RawBytes.Length}");
            if (response.Content.StartsWith("{"))
            {
                throw new MiniProgramArgumentException(JsonConvert.DeserializeObject<JObject>(response.Content)["errmsg"]?.ToString());
            }
            return response.RawBytes;
        }


        private RestClient CreateRestClient(string resourceUrl, Method method, object data, out RestRequest request)
        {
            Logger.Debug(
                $"{method} {BaseApiUrl}/{resourceUrl}{(data != null ? Environment.NewLine + JsonConvert.SerializeObject(data) : string.Empty)}");

            resourceUrl = SetAccessToken(resourceUrl);
            var client = new RestClient(BaseApiUrl);
            request = new RestRequest(resourceUrl, method);
            request.AddHeader("cache-control", "no-cache");
            if (data != null)
            {
                request.AddJsonBody(data);
            }

            return client;
        }

        private string SetAccessToken(string url)
        {
            if (url.IndexOf(AccessTokenString, StringComparison.CurrentCultureIgnoreCase) == -1)
            {
                return url;
            }
            url = url.Replace(AccessTokenString, AccessToken, StringComparison.CurrentCultureIgnoreCase);
            return url;
        }

        private async Task<T> ReturnDataAsync<T>(RestClient client, RestRequest request) where T : ServiceOutputBase, new()
        {
            var response = await client.ExecuteTaskAsync(request);
            Logger.Debug($"{response.StatusCode} {response.Content}");
            var data = JsonConvert.DeserializeObject<T>(response.Content);
            return data;
        }

        /// <summary>
        ///     获取API访问Url
        /// </summary>
        /// <param name="apiAction">操作名</param>
        /// <param name="apiName">API名称</param>
        /// <param name="apiRoot">API根路径</param>
        /// <param name="urlParams">url参数</param>
        /// <returns>API地址</returns>
        protected string GetAccessApiUrl(string apiAction, string apiName, string apiRoot = BaseApiUrl,
            Dictionary<string, string> urlParams = null)
        {
            var paramsStr = string.Empty;
            if (urlParams != null && urlParams.Count > 0)
                paramsStr = urlParams.Aggregate(paramsStr, (current, item) => current +
                                                                              $"&{item.Key}={item.Value}");
            var urlMain = string.IsNullOrEmpty(apiAction) ? apiName : $"{apiName}/{apiAction}";
            return $"{apiRoot}/{urlMain}?access_token={AccessToken}{paramsStr}";
        }
    }
}