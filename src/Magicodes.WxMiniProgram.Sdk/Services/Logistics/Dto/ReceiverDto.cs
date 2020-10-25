using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 收件人
    /// </summary>
    public class ReceiverDto
    {
        /// <summary>
        /// 收件人姓名，不超过64字节
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 收件人座机号码，若不填写则必须填写 mobile，不超过32字节
        /// </summary>
        [JsonProperty("tel")]
        public string Tel { get; set; }

        /// <summary>
        /// 收件人手机号码，若不填写则必须填写 tel，不超过32字节
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 收件人公司名，不超过64字节
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        /// <summary>
        /// 收件人邮编，不超过10字节
        /// </summary>
        [JsonProperty("post_code")]
        public string PostCode { get; set; }

        /// <summary>
        /// 收件人所在国家，不超过64字节
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// 收件人省份，比如："广东省"，不超过64字节
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// 收件人地区/市，比如："广州市"，不超过64字节
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 收件人区/县，比如："天河区"，不超过64字节
        /// </summary>
        [JsonProperty("area")]
        public string Area { get; set; }

        /// <summary>
        /// 收件人详细地址，比如："XX路XX号XX大厦XX"，不超过512字节
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }
    }
}
