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
        protected const string ApiRoot = "https://api.weixin.qq.com";

        protected ServiceBase()
        {
            Logger = NullLogger.Instance;
        }

        public virtual IAccessTokenManager AccessTokenManager { get; set; }
        public virtual HttpClient HttpClient { get; set; }

        public ILogger Logger { get; set; }


        /// <summary>
        ///     接口访问凭据
        /// </summary>
        protected string AccessToken => AccessTokenManager.GetAccessToken();


        /// <summary>
        ///     配置Key
        /// </summary>
        public string Key { get; set; }


        /// <summary>
        ///     获取API访问Url
        /// </summary>
        /// <param name="apiAction">操作名</param>
        /// <param name="apiName">API名称</param>
        /// <param name="apiRoot">API根路径</param>
        /// <param name="urlParams">url参数</param>
        /// <returns>API地址</returns>
        protected string GetAccessApiUrl(string apiAction, string apiName, string apiRoot = ApiRoot,
            Dictionary<string, string> urlParams = null)
        {
            var paramsStr = string.Empty;
            if (urlParams != null && urlParams.Count > 0)
                paramsStr = urlParams.Aggregate(paramsStr, (current, item) => current +
                                                                              $"&{item.Key}={item.Value}");
            var urlMain = string.IsNullOrEmpty(apiAction) ? apiName : $"{apiName}/{apiAction}";
            return $"{apiRoot}/{urlMain}?access_token={AccessToken}{paramsStr}";
        }

        /// <summary>
        ///     获取请求JSON
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <returns>JSON字符串</returns>
        protected virtual async Task<string> GetAsync(string url)
        {
            Logger.Debug(string.Format("pre Get{1}url:{0}", url, Environment.NewLine));
            var result = await HttpClient.GetStringAsync(url);
            Logger.Debug(string.Format("Get success {2}url:{0}{2}result:{1}", url, result,
                Environment.NewLine));
            return result;
        }

        ///// <summary>
        /////     POST提交请求，返回ApiResult对象
        ///// </summary>
        ///// <typeparam name="T">ApiResult对象</typeparam>
        ///// <param name="url">请求地址</param>
        ///// <param name="obj">提交的数据对象</param>
        ///// <param name="serializeStrFunc"></param>
        ///// <returns>ApiResult对象</returns>
        //protected T Post<T>(string url, object obj, Func<string, string> serializeStrFunc = null) where T : ServiceOutput
        //{
        //    var wr = new WeChatApiWebRequestHelper();
        //    var result = wr.HttpPost<T>(url, obj, out string resultStr);
        //    if (result != null)
        //        result.DetailResult = resultStr;
        //    RefreshAccessTokenWhenTimeOut(result);
        //    return result;
        //}

        //protected T Post<T>(string url, object obj, Stream fileStream, Func<string, string> serializeStrFunc = null)
        //    where T : ServiceOutput
        //{
        //    var wr = new WeChatApiWebRequestHelper();
        //    var result = wr.HttpPost<T>(url, obj, out var resultStr);

        //    if (result != null)
        //        result.DetailResult = resultStr;
        //    RefreshAccessTokenWhenTimeOut(result);
        //    return result;
        //}

        ///// <summary>
        ///// Token超时时自动刷新Token
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="result"></param>
        //protected void RefreshAccessTokenWhenTimeOut<T>(T result) where T : ServiceOutput
        //{
        //    //if (result.ReturnCode == ReturnCodes.access_token超时 ||
        //    //    result.ReturnCode == ReturnCodes.获取access_token时AppSecret错误或者access_token无效)
        //    //{
        //    //    WeChatHelper.LoggerAction?.Invoke("RefreshAccessTokenWhenTimeOut", ReturnCodes.获取access_token时AppSecret错误或者access_token无效.ToString() + "  Key:" + Key);
        //    //    WeChatConfigManager.Current.RefreshAccessToken(Key);
        //    //}
        //}

        ///// <summary>
        /////     POST提交请求，返回ApiResult对象
        ///// </summary>
        ///// <typeparam name="T">ApiResult对象</typeparam>
        ///// <param name="url">请求地址</param>
        ///// <param name="jsonData">提交的数据</param>
        ///// <returns>ApiResult对象</returns>
        //protected T Post<T>(string url, string jsonData) where T : ServiceOutput
        //{
        //    var wr = new WeChatApiWebRequestHelper();

        //    WeChatHelper.LoggerAction?.Invoke("api", string.Format("Pre POST Url:{0}；JSON：{1}；", url, jsonData));
        //    var result = wr.HttpPost(url, jsonData);
        //    var obj = JsonConvert.DeserializeObject<T>(result);
        //    if (obj != null)
        //        obj.DetailResult = result;
        //    RefreshAccessTokenWhenTimeOut(obj);
        //    return obj;
        //}

        ///// <summary>
        /////     POST提交请求，上传文件，返回ApiResult对象
        ///// </summary>
        ///// <typeparam name="T">ApiResult对象</typeparam>
        ///// <param name="url">请求地址</param>
        ///// <param name="fileName">文件名称</param>
        ///// <param name="fileStream">文件流</param>
        ///// <returns></returns>
        //protected T Post<T>(string url, string fileName, Stream fileStream) where T : ServiceOutput
        //{
        //    var wr = new WeChatApiWebRequestHelper();
        //    var obj = wr.HttpPost<T>(url, fileName, fileStream, out var result);
        //    if (obj != null)
        //        obj.DetailResult = result;
        //    RefreshAccessTokenWhenTimeOut(obj);
        //    return obj;
        //}


        /// <summary>
        ///     GET提交请求，返回ApiResult对象
        /// </summary>
        /// <typeparam name="T">ApiResult对象</typeparam>
        /// <param name="url">请求地址</param>
        /// <returns>ApiResult对象</returns>
        protected async Task<T> GetAsync<T>(string url) where T : ServiceOutputBase
        {
            var result = await GetAsync(url);
            var obj = JsonConvert.DeserializeObject<T>(result);
            if (obj != null)
                obj.DetailResult = result;
            //RefreshAccessTokenWhenTimeOut(obj);
            return obj;
        }

        /// <summary>
        ///     GET提交请求，返回ApiResult对象
        /// </summary>
        /// <typeparam name="T">ApiResult对象</typeparam>
        /// <param name="url">请求地址</param>
        /// <param name="jsonConverts">Json转换器</param>
        /// <returns>ApiResult对象</returns>
        protected async Task<T> GetAsync<T>(string url, params JsonConverter[] jsonConverts) where T : ServiceOutputBase
        {
            var result = await GetAsync(url);
            var obj = JsonConvert.DeserializeObject<T>(result, jsonConverts);
            if (obj != null)
                obj.DetailResult = result;
            //RefreshAccessTokenWhenTimeOut(obj);
            return obj;
        }
    }
}