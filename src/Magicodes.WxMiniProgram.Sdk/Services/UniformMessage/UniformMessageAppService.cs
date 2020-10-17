using Magicodes.WxMiniProgram.Sdk.Configs;
using Magicodes.WxMiniProgram.Sdk.Services.UniformMessage.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Magicodes.WxMiniProgram.Sdk.Services.UniformMessage
{
    /// <summary>
    /// 下发小程序和公众号统一的服务消息
    /// </summary>
    public class UniformMessageAppService : ServiceBase
    {
        private readonly IMiniProgramConfig _miniProgramConfig;
        private readonly string _url = "/cgi-bin/message/wxopen/template/uniform_send?access_token={ACCESS_TOKEN}";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="miniProgramConfig"></param>
        public UniformMessageAppService(IMiniProgramConfig miniProgramConfig)
        {
            _miniProgramConfig = miniProgramConfig;
        }

        /// <summary>
        /// 下发小程序和公众号统一的服务消息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<UniformMessageSendOutput> SendAsync(UniformMessageSendInput input)
        {
            input.AccessToken = AccessToken;

            return await HttpPost<UniformMessageSendOutput>(_url, input);
        }
    }
}
