using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class InsuredDto
    {
        /// <summary>
        /// 是否保价，0 表示不保价，1 表示保价
        /// </summary>
        [JsonProperty("use_insured")]
        public int UseInsured { get; set;}

        /// <summary>
        /// 保价金额，单位是分，比如: 10000 表示 100 元
        /// </summary>
        [JsonProperty("insured_value")]
        public int InsuredValue { get; set; }
    }
}
