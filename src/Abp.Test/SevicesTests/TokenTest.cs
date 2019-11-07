using System.Threading.Tasks;
using Magicodes.WxMiniProgram.Sdk.Services.Token;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace Abp.Test.SevicesTests
{
    public class TokenTest : TestBase
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly TokenAppService _tokenAppService;

        public TokenTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            this._tokenAppService = Resolve<TokenAppService>();
        }

        [Fact]
        public async Task Get_Test()
        {
            var result = await _tokenAppService.GetAsync();
            _testOutputHelper.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(result));
            result.IsSuccess().ShouldBe(expected: true);
            result.AccessToken.ShouldNotBeNullOrWhiteSpace();
        }
    }
}
