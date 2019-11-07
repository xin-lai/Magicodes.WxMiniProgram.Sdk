using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Magicodes.WxMiniProgram.Sdk.Http
{
    public class WxHttpClient : HttpClient
    {
        public WxHttpClient() : base()
        {
            DefaultRequestHeaders.Accept.Clear();
            BaseAddress = new Uri("https://api.weixin.qq.com");
            DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.57 Safari/537.36");
            DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

        }
    }
}
