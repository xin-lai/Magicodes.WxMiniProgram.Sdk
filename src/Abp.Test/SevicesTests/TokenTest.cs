// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : TokenTest.cs
//           description :
// 
//           created by 雪雁 at  2019-11-07 9:49
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

using System.Threading.Tasks;
using Magicodes.WxMiniProgram.Sdk.Services.Token;
using Newtonsoft.Json;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace Abp.Test.SevicesTests
{
    public class TokenTest : TestBase
    {
        public TokenTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _tokenAppService = Resolve<TokenAppService>();
        }

        private readonly ITestOutputHelper _testOutputHelper;
        private readonly TokenAppService _tokenAppService;

        [Fact]
        public async Task Get_Test()
        {
            var result = await _tokenAppService.GetAsync();
            _testOutputHelper.WriteLine(JsonConvert.SerializeObject(result));
            result.IsSuccess().ShouldBe(true);
            result.AccessToken.ShouldNotBeNullOrWhiteSpace();
        }
    }
}