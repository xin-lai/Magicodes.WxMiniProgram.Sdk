using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.UniformMessage.Dto
{
    /// <summary>
    /// 小程序模板消息相关的信息，可以参考小程序模板消息接口; 有此节点则优先发送小程序模板消息
    /// </summary>
    public class WeappTemplateMsgDto
    {
        /// <summary>
        /// 小程序模板ID
        /// </summary>
        [JsonProperty("template_id")]
        public string TtemplateId { get; set; }

        /// <summary>
        /// 小程序页面路径
        /// </summary>
        [JsonProperty("page")]
        public string Page { get; set; }

        /// <summary>
        /// 小程序模板消息formid
        /// </summary>
        [JsonProperty("form_id")]
        public string FormId { get; set; }

        /// <summary>
        /// 小程序模板数据
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// 小程序模板放大关键词
        /// </summary>
        [JsonProperty("emphasis_keyword")]
        public string EmphasisKeyword { get; set; }
    }
}
