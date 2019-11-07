// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : AccessTokenInfo.cs
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

namespace Magicodes.WxMiniProgram.Sdk.AccessToken.Models
{
    public class AccessTokenInfo : IAccessTokenInfo
    {
        /// <summary>
        ///     访问Token
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        ///     凭证过期时间
        /// </summary>
        public DateTime ExpiresTime { get; set; }
    }
}