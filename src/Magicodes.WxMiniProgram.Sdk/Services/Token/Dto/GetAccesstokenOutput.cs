using System;
using Magicodes.WxMiniProgram.Sdk.AccessToken.Models;
using Newtonsoft.Json;

namespace Magicodes.WxMiniProgram.Sdk.Services.Token.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class GetAccesstokenOutput : ServiceOutputBase, IAccessTokenInfo
    {
        /// <summary>
        /// access_token
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        ///     凭证有效时间，单位：秒
        /// </summary>
        [JsonProperty("expires_in")]
        public int Expires { get; set; }

        /// <summary>
        /// 凭证过期时间
        /// </summary>
        public DateTime ExpiresTime { get; set; }
    }
}
