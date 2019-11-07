// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : AccessTokenManager.cs
//           description :
// 
//           created by 雪雁 at  -- 
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using Magicodes.WxMiniProgram.Sdk.AccessToken.Models;
using Magicodes.WxMiniProgram.Sdk.Configs;

namespace Magicodes.WxMiniProgram.Sdk.AccessToken
{
    /// <summary>
    /// 
    /// </summary>
    public class AccessTokenManager : IAccessTokenManager
    {
        private readonly IMiniProgramConfig _miniProgramConfig;

        protected ConcurrentDictionary<string, IAccessTokenInfo> Tokens =
            new ConcurrentDictionary<string, IAccessTokenInfo>();

        public AccessTokenManager(IMiniProgramConfig miniProgramConfig)
        {
            _miniProgramConfig = miniProgramConfig;
        }

        /// <summary>
        /// 获取AccessToken
        /// </summary>
        /// <returns></returns>
        public Task<string> GetAccessTokenAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取AccessToken
        /// </summary>
        /// <returns></returns>
        public string GetAccessToken()
        {
            //var token= Tokens.GetOrAdd(_miniProgramConfig)
            throw new NotImplementedException();
        }
    }
}