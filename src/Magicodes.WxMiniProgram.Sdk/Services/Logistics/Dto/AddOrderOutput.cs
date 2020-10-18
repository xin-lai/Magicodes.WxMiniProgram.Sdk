using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class AddOrderOutput : ServiceOutputBase
    {
        /// <summary>
        /// 	订单ID，下单成功时返回
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 	运单ID，下单成功时返回
        /// </summary>
        [JsonProperty("waybill_id")]
        public string WaybillId { get; set; }

        /// <summary>
        /// 	运单信息，下单成功时返回
        /// </summary>
        [JsonProperty("waybill_data")]
        public List<KeyValueDto> WaybillData { get; set; }

        /// <summary>
        /// 	快递侧错误码，下单失败时返回
        /// </summary>
        [JsonProperty("delivery_resultcode")]
        public string DeliveryResultcode { get; set; }

        /// <summary>
        /// 	快递侧错误信息，下单失败时返回
        /// </summary>
        [JsonProperty("delivery_resultmsg")]
        public string DeliveryResultmsg { get; set; }
    }
}
