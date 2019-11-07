using System;
using System.Threading.Tasks;
using Magicodes.WxMiniProgram.Sdk.AccessToken.Models;
using Magicodes.WxMiniProgram.Sdk.Configs;
using Magicodes.WxMiniProgram.Sdk.Services.Token.Dto;

namespace Magicodes.WxMiniProgram.Sdk.Services.Token
{
    /// <summary>
    /// 
    /// </summary>
    public class TokenAppService : ServiceBase
    {
        private readonly IMiniProgramConfig _config;

        public TokenAppService(IMiniProgramConfig config) : base()
        {
            _config = config;
        }

        /// <summary>
        /// 获取Accesstoken
        /// </summary>
        /// <returns></returns>
        public async Task<GetAccesstokenOutput> GetAsync()
        {
            if (_config == null)
                throw new MiniProgramArgumentException("没有找到小程序配置信息，请配置！");

            var url = $"{ApiRoot}/cgi-bin/token?grant_type=client_credential&appid={_config.MiniProgramAppId}&secret={_config.MiniProgramAppSecret}";

            var result = await GetAsync<GetAccesstokenOutput>(url);

            if (result.IsSuccess())
                result.ExpiresTime = DateTime.Now.AddSeconds(result.Expires - 30);
            return result;
        }
    }
}
