// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : SnsAppService.cs
//           description :
// 
//           created by 雪雁 at  2019-11-06 17:35
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

using System;
using System.Threading.Tasks;
using Magicodes.WxMiniProgram.Sdk.Configs;
using Magicodes.WxMiniProgram.Sdk.Services.Sns.Dto;

namespace Magicodes.WxMiniProgram.Sdk.Services.Sns
{
    public class QRCodeAppService : ServiceBase
    {
        private const string ApiName = "sns";
        private readonly IMiniProgramConfig _config;

        public QRCodeAppService(IMiniProgramConfig config)
        {
            _config = config;
        }

        /// <summary>
        ///     根据登录凭证获取Sns信息（openid、session_key、unionid）
        /// </summary>
        /// <param name="code">登录时获取的 code</param>
        public async Task<GetSnsInfoByCodeOutput> JscodeToSession(string code)
        {
            if (string.IsNullOrWhiteSpace(code)) throw new ArgumentException("参数不能为空！", nameof(code));
            //获取api请求url
            var url =
                $"{ApiName}/jscode2session?appid={_config.MiniProgramAppId}&secret={_config.MiniProgramAppSecret}&js_code={code}&grant_type=authorization_code";

            return await HttpGet<GetSnsInfoByCodeOutput>(url);
        }
    }
}