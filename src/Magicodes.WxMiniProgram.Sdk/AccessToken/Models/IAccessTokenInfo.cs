using System;

namespace Magicodes.WxMiniProgram.Sdk.AccessToken.Models
{
    public interface IAccessTokenInfo
    {
        /// <summary>
        /// 访问Token
        /// </summary>
        string AccessToken { get; set; }

        /// <summary>
        /// 凭证过期时间
        /// </summary>
        DateTime ExpiresTime { get; set; }
    }
}
