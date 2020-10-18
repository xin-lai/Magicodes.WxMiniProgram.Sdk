using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 获取电子面单余额。仅在使用加盟类快递公司时，才可以调用。
    /// </summary>
    public class GetQuotaOutput : ServiceOutputBase
    {
        /// <summary>
        /// 电子面单余额
        /// </summary>
        [JsonProperty("quota_num")]
        public decimal QuotaNum { get; set; }
    }
}
