using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 包裹信息，将传递给快递公司
    /// </summary>
    public class CargoDto
    {
        /// <summary>
        /// 包裹数量, 需要和detail_list size保持一致
        /// </summary>
        [JsonProperty("count")] 
        public int Count { get; set; }

        /// <summary>
        /// 包裹总重量，单位是千克(kg)
        /// </summary>
        [JsonProperty("weight")]
        public int Weight { get; set; }

        /// <summary>
        /// 包裹长度，单位厘米(cm)
        /// </summary>
        [JsonProperty("space_x")]
        public int SpaceX { get; set; }

        /// <summary>
        /// 包裹宽度，单位厘米(cm)
        /// </summary>
        [JsonProperty("space_y")]
        public int SpaceY { get; set; }

        /// <summary>
        /// 包裹高度，单位厘米(cm)
        /// </summary>
        [JsonProperty("space_z")]
        public int SpaceZ { get; set; }

        /// <summary>
        /// 包裹中商品详情列表
        /// </summary>
        [JsonProperty("detail_list")]
        public List<CargoDetailDto> CargoDetails { get; set; }
    }
}
