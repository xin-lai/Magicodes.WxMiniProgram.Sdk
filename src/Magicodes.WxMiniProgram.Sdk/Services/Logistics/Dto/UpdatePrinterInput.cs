using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 配置面单打印员，可以设置多个，若需要使用微信打单 PC 软件，才需要调用。
    /// </summary>
    public class UpdatePrinterInput : ServiceInputBase
    {
        /// <summary>
        /// 打印员 openid
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 更新类型，bind-绑定，unbind-解除绑定
        /// </summary>
        [JsonProperty("update_type")]
        public string UpdateType { get; set; }

        /// <summary>
        /// 用于平台型小程序设置入驻方的打印员面单打印权限，同一打印员最多支持10个tagid，使用半角逗号分隔，中间不加空格，如填写123,456，表示该打印员可以拉取到tagid为123和456的下的单，非平台型小程序无需填写该字段
        /// </summary>
        [JsonProperty("tagid_list")]
        public string TagIds { get; set; }
    }
}
