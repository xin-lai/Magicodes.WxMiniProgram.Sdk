using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 查询运单轨迹
    /// </summary>
    public class GetPathOutput : ServiceOutputBase
    {
        /// <summary>
        /// 用户openid
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 快递公司 ID
        /// </summary>
        [JsonProperty("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 运单 ID
        /// </summary>
        [JsonProperty("waybill_id")]
        public string WaybillId { get; set; }

        /// <summary>
        /// 轨迹节点数量
        /// </summary>
        [JsonProperty("path_item_num")]
        public int PathItemNum { get; set; }

        /// <summary>
        /// 轨迹节点列表
        /// </summary>
        [JsonProperty("path_item_list")]
        public List<PathItemDto> PathItems { get; set; }
    }
}
