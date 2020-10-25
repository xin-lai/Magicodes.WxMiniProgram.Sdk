using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 获取支持的快递公司列表
    /// </summary>
    public class GetAllDeliveryOutput : ServiceOutputBase
    {
        /// <summary>
        /// 快递公司数量
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// 快递公司信息列表
        /// </summary>
        [JsonProperty("data")]
        public List<DeliveryDto> Data { get; set; }
    }
}
