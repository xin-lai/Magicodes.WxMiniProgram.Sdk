using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 获取所有绑定的物流账号
    /// </summary>
    public class GetAllAccountOutput : ServiceOutputBase
    {
        /// <summary>
        /// 账号数量
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// 账号列表
        /// </summary>
        [JsonProperty("list")]
        public List<AccountDto> Accounts { get; set; }
    }
}
