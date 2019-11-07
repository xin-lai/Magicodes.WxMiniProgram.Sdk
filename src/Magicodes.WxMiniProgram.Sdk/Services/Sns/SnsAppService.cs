using System;
using System.Threading.Tasks;
using Magicodes.WxMiniProgram.Sdk.Configs;
using Magicodes.WxMiniProgram.Sdk.Services.Sns.Dto;

namespace Magicodes.WxMiniProgram.Sdk.Services.Sns
{
    public class SnsAppService : ServiceBase
    {
        private readonly IMiniProgramConfig _config;

        public SnsAppService(IMiniProgramConfig config)
        {
            _config = config;
        }

        private const string ApiName = "sns";
        /// <summary>
        /// 根据登录凭证获取Sns信息（openid、session_key、unionid）
        /// </summary>
        /// <param name="code">登录时获取的 code</param>
        public async Task<GetSnsInfoByCodeOutput> JscodeToSession(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                throw new ArgumentException("message", nameof(code));
            }
            //获取api请求url
            var url = $"{ApiName}/jscode2session?appid={_config.MiniProgramAppId}&secret={_config.MiniProgramAppSecret}&js_code={code}&grant_type=authorization_code";

            return await GetAsync<GetSnsInfoByCodeOutput>(url);
        }
    }
}
