using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 生成运单
    /// </summary>
    public class AddOrderInput : ServiceInputBase
    {
        /// <summary>
        /// 订单来源，0为小程序订单，2为App或H5订单，填2则不发送物流服务通知
        /// </summary>
        [JsonProperty("add_source")]
        public int AddSource { get; set; }

        /// <summary>
        /// App或H5的appid，add_source=2时必填，需和开通了物流助手的小程序绑定同一open帐号
        /// </summary>
        [JsonProperty("wx_appid")]
        public string WxAppid { get; set; }

        /// <summary>
        /// 订单ID，须保证全局唯一，不超过512字节
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 用户openid，当add_source=2时无需填写（不发送物流服务通知）
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 快递公司ID，参见getAllDelivery
        /// </summary>
        [JsonProperty("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 快递客户编码或者现付编码
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 快递备注信息，比如"易碎物品"，不超过1024字节
        /// </summary>
        [JsonProperty("custom_remark")]
        public string CustomRemark { get; set; }

        /// <summary>
        /// 订单标签id，用于平台型小程序区分平台上的入驻方，tagid须与入驻方账号一一对应，非平台型小程序无需填写该字段
        /// </summary>
        [JsonProperty("tagid")]
        public int TagId { get; set; }

        /// <summary>
        /// 发件人信息
        /// </summary>
        [JsonProperty("Sender")]
        public SenderDto Sender { get; set; }

        /// <summary>
        /// 收件人信息
        /// </summary>
        [JsonProperty("receiver")]
        public ReceiverDto Receiver { get; set; }

        /// <summary>
        /// 包裹信息，将传递给快递公司
        /// </summary>
        [JsonProperty("cargo")]
        public CargoDto Cargo { get; set; }

        /// <summary>
        /// 商品信息，会展示到物流服务通知和电子面单中
        /// </summary>
        [JsonProperty("shop")]
        public ShopDto Shop { get; set; }

        /// <summary>
        /// 保价信息
        /// </summary>
        [JsonProperty("insured")]
        public InsuredDto Insured { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [JsonProperty("service")]
        public ServiceDto Service { get; set; }

        /// <summary>
        /// Unix 时间戳, 单位秒，顺丰必须传。 预期的上门揽件时间，0表示已事先约定取件时间；否则请传预期揽件时间戳，需大于当前时间，收件员会在预期时间附近上门。例如expect_time为“1557989929”，表示希望收件员将在2019年05月16日14:58:49-15:58:49内上门取货。说明：若选择 了预期揽件时间，请不要自己打单，由上门揽件的时候打印。如果是下顺丰散单，则必传此字段，否则不会有收件员上门揽件。
        /// </summary>
        [JsonProperty("expect_time")]
        public int ExpectTime { get; set; }
    }
}
