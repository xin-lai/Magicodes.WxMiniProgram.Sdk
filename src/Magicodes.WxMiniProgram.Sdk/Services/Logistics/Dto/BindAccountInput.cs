using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 绑定、解绑物流账号
    /// </summary>
    public class BindAccountInput : ServiceInputBase
    {
        /// <summary>
        /// bind表示绑定，unbind表示解除绑定
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 快递公司客户编码
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 快递公司ID
        /// </summary>
        [JsonProperty("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 快递公司客户密码, ems，顺丰，京东非必填
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// 备注内容（提交EMS审核需要）
        /// </summary>
        [JsonProperty("remark_content")]
        public string RemarkContent { get; set; }
    }
}
