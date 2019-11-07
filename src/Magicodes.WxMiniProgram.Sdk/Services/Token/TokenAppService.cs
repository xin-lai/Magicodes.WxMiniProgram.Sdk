// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : TokenAppService.cs
//           description :
// 
//           created by 雪雁 at  2019-11-04 15:13
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

using System;
using System.Threading.Tasks;
using Magicodes.WxMiniProgram.Sdk.Configs;
using Magicodes.WxMiniProgram.Sdk.Services.Token.Dto;

namespace Magicodes.WxMiniProgram.Sdk.Services.Token
{
    /// <summary>
    /// </summary>
    public class TokenAppService : ServiceBase
    {
        private readonly IMiniProgramConfig _config;

        public TokenAppService(IMiniProgramConfig config)
        {
            _config = config;
        }

        /// <summary>
        ///     获取Accesstoken
        /// </summary>
        /// <returns></returns>
        public async Task<GetAccesstokenOutput> GetAsync()
        {
            if (_config == null)
                throw new MiniProgramArgumentException("没有找到小程序配置信息，请配置！");

            var url =
                $"{ApiRoot}/cgi-bin/token?grant_type=client_credential&appid={_config.MiniProgramAppId}&secret={_config.MiniProgramAppSecret}";

            var result = await GetAsync<GetAccesstokenOutput>(url);

            if (result.IsSuccess())
                result.ExpiresTime = DateTime.Now.AddSeconds(result.Expires - 30);
            return result;
        }
    }
}