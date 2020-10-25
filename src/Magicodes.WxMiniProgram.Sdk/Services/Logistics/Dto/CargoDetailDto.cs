using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 包裹中商品详情列表
    /// </summary>
    public class CargoDetailDto
    {
        /// <summary>
        /// 商品名，不超过128字节
        /// </summary>
        [JsonProperty("name")] 
        public string Name { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
