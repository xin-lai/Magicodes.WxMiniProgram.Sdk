// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : ReturnCodes.cs
//           description :
// 
//           created by 雪雁 at  2019-11-04 15:18
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

namespace Magicodes.WxMiniProgram.Sdk.Services
{
    /// <summary>
    ///     公众号返回码（JSON）
    /// </summary>
    public enum ReturnCodes
    {
        请求成功 = 0,
        系统繁忙_此时请开发者稍候再试 = -1,
        AppSecret错误或者AppSecret不属于这个小程序_请开发者确认AppSecret的正确性 = 40001,
        请确保grant_type字段值为client_credential = 40002,
        不合法的AppID_请开发者检查AppID的正确性 = 40013,
        授权Code不正确 = 40029,
        template_id不正确 = 40037,
        form_id不正确或过期 = 41028,
        form_id已被使用 = 41029,
        page不正确 = 41030,
        接口调用超过限额_目前默认每个帐号日调用限额为100万 = 45009
    }
}