using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 获取运单数据
    /// </summary>
    public class GetOrderInput : ServiceInputBase
    {
        /// <summary>
        /// 订单 ID，需保证全局唯一
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 用户openid，当add_source=2时无需填写（不发送物流服务通知）
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 快递公司ID，参见getAllDelivery, 必须和waybill_id对应
        /// </summary>
        [JsonProperty("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 运单ID
        /// </summary>
        [JsonProperty("waybill_id")]
        public string WaybillId { get; set; }
    }
}
