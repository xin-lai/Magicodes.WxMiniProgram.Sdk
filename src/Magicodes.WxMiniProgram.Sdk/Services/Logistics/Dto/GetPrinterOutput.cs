using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class GetPrinterOutput : ServiceOutputBase
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("openid")]
        public List<string> OpenIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tagid_list")]
        public List<string> TagIds { get; set; }
    }
}
