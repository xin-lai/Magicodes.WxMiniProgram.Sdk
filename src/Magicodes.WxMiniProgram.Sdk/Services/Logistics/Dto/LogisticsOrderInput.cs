using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 物流订单
    /// </summary>
    public class LogisticsOrderInput
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 快递公司ID，参见getAllDelivery
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
