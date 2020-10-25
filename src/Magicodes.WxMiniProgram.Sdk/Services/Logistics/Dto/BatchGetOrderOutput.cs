using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 批量获取运单数据
    /// </summary>
    public class BatchGetOrderOutput : ServiceOutputBase
    {
        /// <summary>
        /// 运单列表
        /// </summary>
        [JsonProperty("order_list")]
        public List<LogisticsOrderOutput> OrderList { get; set; }

        /// <summary>
        /// 运单状态, 0正常，1取消
        /// </summary>
        [JsonProperty("order_status")]
        public int OrderStatus { get; set; }
    }
}
