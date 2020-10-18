using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto
{
    /// <summary>
    /// 物流账号
    /// </summary>
    public class AccountDto
    {
        /// <summary>
        /// 快递公司客户编码
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 快递公司ID
        /// </summary>
        [JsonProperty("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 账号绑定时间
        /// </summary>
        [JsonProperty("create_time")]
        public int CreateTime { get; set; }

        /// <summary>
        /// 账号更新时间
        /// </summary>
        [JsonProperty("update_time")]
        public int UpdateTime { get; set; }

        /// <summary>
        /// 绑定状态0-绑定成功，1-审核中，2-绑定失败，3-已解绑
        /// </summary>
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        /// <summary>
        /// 账号别名
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 账号绑定失败的错误信息（EMS审核结果）
        /// </summary>
        [JsonProperty("remark_wrong_msg")]
        public string RemarkWrongMsg { get; set; }

        /// <summary>
        /// 账号绑定时的备注内容（提交EMS审核需要）
        /// </summary>
        [JsonProperty("remark_content")]
        public string RemarkContent { get; set; }

        /// <summary>
        /// 电子面单余额
        /// </summary>
        [JsonProperty("quota_num")]
        public decimal QuotaNum { get; set; }

        /// <summary>
        /// 电子面单余额更新时间
        /// </summary>
        [JsonProperty("quota_update_time")]
        public int QuotaUpdateTime { get; set; }

        /// <summary>
        /// 该绑定帐号支持的服务类型
        /// </summary>
        [JsonProperty("service_type")]
        public List<ServiceDto> ServiceType { get; set; }
    }
}
