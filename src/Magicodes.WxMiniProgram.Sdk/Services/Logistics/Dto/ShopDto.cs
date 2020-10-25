using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 商品信息，会展示到物流服务通知和电子面单中
    /// </summary>
    public class ShopDto
    {
        /// <summary>
        /// 商家小程序的路径，建议为订单页面
        /// </summary>
        [JsonProperty("wxa_path")]
        public string WxaPath { get; set; }


        /// <summary>
        /// 商品缩略图 url
        /// </summary>
        [JsonProperty("img_url")]
        public string ImgUrl { get; set; }


        /// <summary>
        /// 商品名称, 不超过128字节
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }


        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("goods_count")]
        public int GoodsCount { get; set; }
    }
}
