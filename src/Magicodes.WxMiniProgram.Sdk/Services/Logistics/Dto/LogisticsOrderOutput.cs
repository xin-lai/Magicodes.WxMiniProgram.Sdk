using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class LogisticsOrderOutput : ServiceOutputBase
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 	快递公司ID，参见getAllDelivery
        /// </summary>
        [JsonProperty("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 		运单ID
        /// </summary>
        [JsonProperty("waybill_id")]
        public string WaybillId { get; set; }

        /// <summary>
        /// 运单 html 的 BASE64 结果
        /// </summary>
        [JsonProperty("print_html")]
        public string PrintHtml { get; set; }

        /// <summary>
        /// 运单信息
        /// </summary>
        [JsonProperty("waybill_data")]
        public List<KeyValueDto> WaybillData { get; set; }
    }
}
