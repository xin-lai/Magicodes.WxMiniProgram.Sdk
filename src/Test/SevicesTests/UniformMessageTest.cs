using Magicodes.WxMiniProgram.Sdk.Configs;
using Magicodes.WxMiniProgram.Sdk.Services.UniformMessage;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test.SevicesTests
{
    public class UniformMessageTest : TestBase
    {
        private readonly UniformMessageAppService _uniformMessageService;
        private readonly IMiniProgramConfig _miniProgramConfig;

        public UniformMessageTest()
        {
            _uniformMessageService = Resolve<UniformMessageAppService>();
            _miniProgramConfig = new DefaultMiniProgramConfig();
            _miniProgramConfig.MiniProgramAppId = "wxea60106d88226354";
            _miniProgramConfig.MiniProgramAppSecret = "";
        }


        [Fact]
        public async Task UniformMessage_Send_Test()
        {
            dynamic data = new
            {
                amount1 = new { value = 1000 },
                amount2 = new { value = 1000 },
                time3 = new { value = "2020-10-10 21:29:29" },
                thing4 = new { value = "温馨提示" }
            };
            var result = await _uniformMessageService.SendAsync(new Magicodes.WxMiniProgram.Sdk.Services.UniformMessage.Dto.UniformMessageSendInput
            {
                MpTemplateMsg = new Magicodes.WxMiniProgram.Sdk.Services.UniformMessage.Dto.MpTemplateMsgDto
                {
                    Appid = _miniProgramConfig.MiniProgramAppId,
                    TemplateId = "SPYzk1nzIj9l3-60QvP_C_rS1xEHojhiQwduG2vOBxo",
                    Url = "/pages/index/index",
                    Miniprogram = "",
                    Data = Newtonsoft.Json.JsonConvert.SerializeObject(data),
                },
                Touser = "oeDrz5Dv9UqAgHO6fopkUVhtAlD4",
                WeappTemplateMsg = new Magicodes.WxMiniProgram.Sdk.Services.UniformMessage.Dto.WeappTemplateMsgDto
                {

                },
            });
            result.IsSuccess().ShouldBe(true);
        }
    }
}
