// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : WxHttpClient.cs
//           description :
// 
//           created by 雪雁 at  2019-11-06 11:34
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Magicodes.WxMiniProgram.Sdk.Http
{
    public class WxHttpClient : HttpClient
    {
        public WxHttpClient()
        {
            DefaultRequestHeaders.Accept.Clear();
            BaseAddress = new Uri("https://api.weixin.qq.com");
            DefaultRequestHeaders.Add("User-Agent",
                "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.57 Safari/537.36");
            DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}