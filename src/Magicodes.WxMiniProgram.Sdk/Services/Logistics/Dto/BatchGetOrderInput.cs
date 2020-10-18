using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 批量获取运单数据
    /// </summary>
    public class BatchGetOrderInput : ServiceInputBase
    {
        /// <summary>
        /// 订单列表, 最多不能超过100个
        /// </summary>
        [JsonProperty("order_list")]
        public List<LogisticsOrderInput> OrderList { get; set; }
    }
}
