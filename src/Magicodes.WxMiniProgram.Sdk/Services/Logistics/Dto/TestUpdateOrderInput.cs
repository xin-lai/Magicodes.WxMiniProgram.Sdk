using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 模拟快递公司更新订单状态, 该接口只能用户测试
    /// </summary>
    public class TestUpdateOrderInput : ServiceInputBase
    {
        /// <summary>
        /// 商户id,需填test_biz_id
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 快递公司id,需填TEST
        /// </summary>
        [JsonProperty("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [JsonProperty("waybill_id")]
        public string WaybillId { get; set; }

        /// <summary>
        /// 轨迹变化 Unix 时间戳
        /// </summary>
        [JsonProperty("action_time")]
        public int ActionTime { get; set; }

        /// <summary>
        /// 轨迹变化类型
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
        /// 轨迹变化具体信息说明,使用UTF-8编码
        /// </summary>
        [JsonProperty("action_msg")]
        public string ActionMsg { get; set; }
    }
}
