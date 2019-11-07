// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : GetSnsInfoByCodeOutput.cs
//           description :
// 
//           created by 雪雁 at  2019-11-06 17:35
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

using Newtonsoft.Json;

namespace Magicodes.WxMiniProgram.Sdk.Services.Sns.Dto
{
    /// <summary>
    /// </summary>
    public class GetSnsInfoByCodeOutput : ServiceOutputBase
    {
        /// <summary>
        ///     用户唯一标识
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        ///     会话密钥
        /// </summary>
        [JsonProperty("session_key")]
        public string SessionKey { get; set; }

        /// <summary>
        ///     用户在开放平台的唯一标识符。本字段在满足一定条件的情况下才返回。具体参看：https://mp.weixin.qq.com/debug/wxadoc/dev/api/uinionID.html
        /// </summary>
        [JsonProperty("unionid")]
        public string UnionId { get; set; }
    }
}