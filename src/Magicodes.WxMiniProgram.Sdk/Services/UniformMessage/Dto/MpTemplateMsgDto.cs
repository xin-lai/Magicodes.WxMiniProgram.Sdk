using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.UniformMessage.Dto
{
    /// <summary>
    /// 公众号模板消息相关的信息，可以参考公众号模板消息接口；有此节点并且没有weapp_template_msg节点时，发送公众号模板消息
    /// </summary>
    public class MpTemplateMsgDto
    {
        /// <summary>
        /// 公众号appid，要求与小程序有绑定且同主体
        /// </summary>
        [JsonProperty("appid")]
        public string Appid { get; set; }


        /// <summary>
        /// 公众号模板id
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }


        /// <summary>
        /// 公众号模板消息所要跳转的url
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// 公众号模板消息所要跳转的小程序，小程序的必须与公众号具有绑定关系
        /// </summary>
        [JsonProperty("miniprogram")]
        public string Miniprogram { get; set; }

        /// <summary>
        /// 公众号模板消息的数据
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}
