using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 服务类型
    /// </summary>
    public class ServiceDto
    {
        /// <summary>
        /// 服务类型ID，详见已经支持的快递公司基本信息
        /// </summary>
        [JsonProperty("service_type")]
        public int ServiceType { get; set; }

        /// <summary>
        /// 服务名称，详见已经支持的快递公司基本信息
        /// </summary>
        [JsonProperty("service_name")]
        public string ServiceName { get; set; }
    }
}
