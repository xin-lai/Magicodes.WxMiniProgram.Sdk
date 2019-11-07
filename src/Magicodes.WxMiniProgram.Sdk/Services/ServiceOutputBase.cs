// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : ServiceOutputBase.cs
//           description :
// 
//           created by 雪雁 at  2019-11-04 15:18
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

using Newtonsoft.Json;

namespace Magicodes.WxMiniProgram.Sdk.Services
{
    /// <summary>
    ///     API请求结果
    /// </summary>
    public class ServiceOutputBase
    {
        /// <summary>
        ///     返回码
        /// </summary>
        [JsonProperty("errcode")]
        public virtual ReturnCodes ReturnCode { get; set; }

        /// <summary>
        ///     错误消息
        /// </summary>
        [JsonProperty("errmsg")]
        public virtual string Message { get; set; }

        /// <summary>
        ///     请求详情（一般请忽略）
        /// </summary>
        public virtual string DetailResult { get; set; }

        /// <summary>
        ///     是否为成功返回
        /// </summary>
        /// <returns></returns>
        public virtual bool IsSuccess()
        {
            return ReturnCode == ReturnCodes.请求成功;
        }

        /// <summary>
        ///     获取友好提示
        /// </summary>
        /// <returns></returns>
        public virtual string GetFriendlyMessage()
        {
            return ReturnCode.ToString();
        }
    }
}