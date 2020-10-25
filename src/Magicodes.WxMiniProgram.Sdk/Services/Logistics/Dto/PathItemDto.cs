using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 轨迹
    /// </summary>
    public class PathItemDto
    {
        /// <summary>
        /// 轨迹节点 Unix 时间戳
        /// </summary>
        [JsonProperty("action_time")]
        public int ActionTime { get; set; }

        /// <summary>
        /// 轨迹节点类型
        ///100001	揽件阶段-揽件成功	
        ///100002	揽件阶段-揽件失败	
        ///100003	揽件阶段-分配业务员	
        ///200001	运输阶段-更新运输轨迹	
        ///300002	派送阶段-开始派送	
        ///300003	派送阶段-签收成功	
        ///300004	派送阶段-签收失败	
        ///400001	异常阶段-订单取消	
        ///400002	异常阶段-订单滞留
        /// </summary>
        [JsonProperty("action_type")]
        public int ActionType { get; set; }

        /// <summary>
        /// 轨迹节点详情
        /// </summary>
        [JsonProperty("action_msg")]
        public string ActionMsg { get; set; }
    }
}
