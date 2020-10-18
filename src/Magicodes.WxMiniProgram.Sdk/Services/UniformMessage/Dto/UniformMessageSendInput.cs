using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.UniformMessage.Dto
{
    /// <summary>
    /// 下发小程序和公众号统一的服务消息 输入参数
    /// </summary>
    public class UniformMessageSendInput : ServiceInputBase
    {
        /// <summary>
        /// 用户openid，可以是小程序的openid，也可以是mp_template_msg.appid对应的公众号的openid
        /// </summary>
        [JsonProperty("touser")]
        public string Touser { get; set; }

        /// <summary>
        /// 小程序模板消息相关的信息，可以参考小程序模板消息接口; 有此节点则优先发送小程序模板消息
        /// </summary>
        [JsonProperty("weapp_template_msg")]
        public WeappTemplateMsgDto WeappTemplateMsg { get; set; }

        /// <summary>
        /// 公众号模板消息相关的信息，可以参考公众号模板消息接口；有此节点并且没有weapp_template_msg节点时，发送公众号模板消息
        /// </summary>
        [JsonProperty("mp_template_msg")]
        public MpTemplateMsgDto MpTemplateMsg { get; set; }
    }
}
