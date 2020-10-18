using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 获取电子面单余额。仅在使用加盟类快递公司时，才可以调用。
    /// </summary>
    public class GetQuotaInput : ServiceInputBase
    {
        /// <summary>
        /// 快递公司ID，参见getAllDelivery
        /// </summary>
        [JsonProperty("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 快递公司客户编码
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }
    }
}
