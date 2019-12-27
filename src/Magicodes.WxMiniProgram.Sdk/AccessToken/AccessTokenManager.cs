// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : AccessTokenManager.cs
//           description :
// 
//           created by 雪雁 at  2019-11-06 11:34
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using Castle.Core.Logging;
using Magicodes.WxMiniProgram.Sdk.AccessToken.Models;
using Magicodes.WxMiniProgram.Sdk.Configs;
using Magicodes.WxMiniProgram.Sdk.Services.Token;
using Microsoft.Extensions.Caching.Distributed;

namespace Magicodes.WxMiniProgram.Sdk.AccessToken
{
    /// <summary>
    /// </summary>
    public class AccessTokenManager : IAccessTokenManager
    {
        private const string Key = "WxMiniProgramAccessToken";

        //见：https://docs.microsoft.com/zh-cn/aspnet/core/performance/caching/distributed?view=aspnetcore-2.1
        private readonly IDistributedCache _cache;
        private readonly TokenAppService _tokenApi;

        /// <summary>
        /// 
        /// </summary>
        public ILogger Logger { get; set; }

        public AccessTokenManager(IDistributedCache cache, TokenAppService tokenApi)
        {
            _cache = cache;
            Logger = NullLogger.Instance;
            _tokenApi = tokenApi;
        }

        /// <summary>
        ///     获取AccessToken
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetAccessTokenAsync()
        {
            var value = await _cache.GetStringAsync(Key);
            if (!string.IsNullOrEmpty(value)) return value;

            var result = await _tokenApi.GetAsync();
            value = result.AccessToken;
            Logger.Debug("Token获取成功...");
            await _cache.SetStringAsync(Key, value,
                new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(7000)));
            Logger.Debug("Token已写入缓存...");
            return value;
        }

    }
}