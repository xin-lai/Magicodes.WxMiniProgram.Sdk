using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 取消运单
    /// </summary>
    public class CancelOrderOutput : ServiceOutputBase
    {
        /// <summary>
        /// 运力返回的错误码
        /// </summary>
        [JsonProperty("delivery_resultcode")]
        public int DeliveryResultcode { get; set; }

        /// <summary>
        /// 运力返回的错误信息
        /// </summary>
        [JsonProperty("delivery_resultmsg")]
        public string DeliveryResultmsg { get; set; }
    }
}
