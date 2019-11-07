// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : GetAccesstokenOutput.cs
//           description :
// 
//           created by 雪雁 at  2019-11-04 15:13
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

using System;
using Magicodes.WxMiniProgram.Sdk.AccessToken.Models;
using Newtonsoft.Json;

namespace Magicodes.WxMiniProgram.Sdk.Services.Token.Dto
{
    /// <summary>
    /// </summary>
    public class GetAccesstokenOutput : ServiceOutputBase, IAccessTokenInfo
    {
        /// <summary>
        ///     凭证有效时间，单位：秒
        /// </summary>
        [JsonProperty("expires_in")]
        public int Expires { get; set; }

        /// <summary>
        ///     access_token
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        ///     凭证过期时间
        /// </summary>
        public DateTime ExpiresTime { get; set; }
    }
}