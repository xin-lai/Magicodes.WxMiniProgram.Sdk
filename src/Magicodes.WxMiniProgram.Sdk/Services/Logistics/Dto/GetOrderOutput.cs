using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 获取运单数据
    /// </summary>
    public class GetOrderOutput : ServiceOutputBase
    {
        /// <summary>
        /// 运单 html 的 BASE64 结果
        /// </summary>
        [JsonProperty("print_html")]
        public string PrintHtml { get; set; }

        /// <summary>
        /// 	运单信息
        /// </summary>
        [JsonProperty("waybill_data")]
        public List<KeyValueDto> WaybillData { get; set; }

        /// <summary>
        /// 快递公司ID
        /// </summary>
        [JsonProperty("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 	运单号
        /// </summary>
        [JsonProperty("waybill_id")]
        public string WaybillId { get; set; }

        /// <summary>
        /// 	运单状态, 0正常，1取消
        /// </summary>
        [JsonProperty("order_status")]
        public int OrderStatus { get; set; }
    }
}
