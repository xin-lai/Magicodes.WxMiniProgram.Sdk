using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 快递公司
    /// </summary>
    public class DeliveryDto
    {
        /// <summary>
        /// 快递公司 ID
        /// </summary>
        [JsonProperty("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 快递公司名称
        /// </summary>
        [JsonProperty("delivery_name")]
        public string DeliveryName { get; set; }

        /// <summary>
        /// 	是否支持散单, 1表示支持
        /// </summary>
        [JsonProperty("can_use_cash")]
        public int CanUseCash { get; set; }

        /// <summary>
        /// 	是否支持查询面单余额, 1表示支持
        /// </summary>
        [JsonProperty("can_get_quota")]
        public int CanGetQuota { get; set; }

        /// <summary>
        /// 	散单对应的bizid，当can_use_cash=1时有效
        /// </summary>
        [JsonProperty("cash_biz_id")]
        public string CashBizId { get; set; }

        /// <summary>
        /// 	支持的服务类型
        /// </summary>
        [JsonProperty("service_type")]
        public List<ServiceDto> ServiceType { get; set; }
    }
}
