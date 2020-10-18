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
            _miniProgramConfig = Resolve<IMiniProgramConfig>();
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
                Touser = "oeDrz5Dv9UqAgHO6fopkUVhtAlD4、" +
                "",
                WeappTemplateMsg = new Magicodes.WxMiniProgram.Sdk.Services.UniformMessage.Dto.WeappTemplateMsgDto
                {
                    EmphasisKeyword = "",
                    FormId = "SPYzk1nzIj9l3-60QvP_C_rS1xEHojhiQwduG2vOBxo",
                    Page = "/pages/index/index",
                    TtemplateId = "SPYzk1nzIj9l3-60QvP_C_rS1xEHojhiQwduG2vOBxo",
                    Data = Newtonsoft.Json.JsonConvert.SerializeObject(data),
                },
            });
            result.IsSuccess().ShouldBe(true);
        }
    }
}
