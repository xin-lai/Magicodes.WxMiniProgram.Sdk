[TOC]

# Magicodes.WxMiniProgram.Sdk

轻量级微信小程序SDK，支持.NET Framework以及.NET Core。目前已提供Abp模块的封装，支持开箱即用。

## Nuget

### 新的包

| 名称     |      说明      |      Nuget      |
|----------|:-------------:|:-------------:|
| Magicodes.WxMiniProgram.Sdk  |微信小程序SDK|  [![NuGet](https://buildstats.info/nuget/Magicodes.WxMiniProgram.Sdk)](https://www.nuget.org/packages/Magicodes.WxMiniProgram.Sdk) |
| Magicodes.WxMiniProgram.Sdk.Abp  |微信小程序SDK Abp模块|   [![NuGet](https://buildstats.info/nuget/Magicodes.WxMiniProgram.Sdk.Abp)](https://www.nuget.org/packages/Magicodes.WxMiniProgram.Sdk.Abp) |

## 主要功能

轻量级微信小程序SDK，以便于简单方便的实现小程序服务端API的调用。具体见单元测试。

## RoadMap

- [ ] 完善接口
  - [x] 登录
  - [ ] 用户信息
  - [x] 接口调用凭证
  - [ ] 数据分析
  - [ ] 客服消息
  - [ ] 模板消息
  - [ ] 统一服务消息
  - [ ] 动态消息
  - [ ] 插件管理
  - [ ] 附近的小程序
  - [x] 小程序码
  - [ ] 内容安全
  - [ ] 广告
  - [ ] 图像处理
  - [ ] OCR
  - [ ] 运维中心
  - [ ] 搜索
  - [ ] 生物认证
  - [ ] 订阅消息
- [ ] AccessToken自动传参，无需显式指定
- [ ] 方法参数改成类参数，并且支持通过特性校验

## 更新历史

### 0.0.5

------

- [x] 重构AccessToken管理
- [x] 添加对分布式架构支持（使用分布式缓存）
- [x] 重构Http请求模块，移除HttpClient
- [x] 添加获取二维码接口（Create、Get、GetUnlimited），详见单元测试

## 开始使用

如果使用Abp相关模块，则使用起来比较简单，具体您可以参考相关单元测试的编写。主要有以下步骤：

1. 引用对应的Abp的Nuget包

如果仅需某个支付，仅需引用该支付的包。下面以通联支付为例，我们需要在工程中引用此包：

| 名称     |      说明      |      Nuget      |
|----------|:-------------:|:-------------:|
| Magicodes.WxMiniProgram.Sdk.Abp  |微信小程序SDK Abp模块|   [![NuGet](https://buildstats.info/nuget/Magicodes.WxMiniProgram.Sdk.Abp)](https://www.nuget.org/packages/Magicodes.WxMiniProgram.Sdk.Abp) |

2. 添加模块依赖

在对应工程的Abp的模块（AbpModule）中，添加对“WxMiniProgramSdkModule”的依赖，如：

````C#
    [DependsOn(typeof(WxMiniProgramSdkModule))]
````

3. 直接使用

通过构造函数或者属性注入相关服务，即可直接使用。

## 如何配置？

对于ABP集成，则可以通过以下方式获取配置：

- 配置文件，如：

````C#
  "App_MiniProgram": {
    "MiniProgramAppId": "wx25fa5d55ef27e086",
    "MiniProgramAppSecret": "ab02ac4499c9764108a78e19476d7101"
  }
````

以上为个人小程序号配置，仅用于测试，请勿乱搞！

- 配置管理器

需存储JSON对象，对应的key为“App_MiniProgram”。

对于非ABP集成，则需要自己实例化或注入配置类对象，可以参考单元测试的编写。

## 非ABP集成

请参考Abp相关模块的封装或者相关的单元测试代码，目前“Test”工程对应非ABP集成方式的使用，“Abp.Test”工程对应集成ABP之后的使用。

## 分布式缓存配置

为了支持分布式架构，已引入IDistributedCache来支持分布式缓存，在开发测试或单主机服务中，需使用以下代码进行注入：

```csharp
services.AddDistributedMemoryCache();
```

如需使用Redis，请参考下面代码：

```csharp
services.AddDistributedRedisCache(options =>
{
    options.Configuration = "localhost";
    options.InstanceName = "SampleInstance";
});
```

[相关文档请参考]: https://docs.microsoft.com/zh-cn/aspnet/core/performance/caching/distributed?view=aspnetcore-3.1#distributed-redis-cache

## 如何添加API？（PR）

由于作者精力有限，非常欢迎各位参与共建。主体步骤如下所示：

### 1.添加目录

在工程【Magicodes.WxMiniProgram.Sdk】下的【Services】目录下添加对应业务模块目录，比如二维码为“QRCode”。

### 2.添加对应接口的AppService

例如添加QRCodeAppService，继承自ServiceBase

### 3.基于ServiceBase提供的封装来编写接口逻辑

例如以下代码，获取永久二维码：

```csharp
    /// <summary>
    /// 获取小程序码，适用于需要的码数量较少的业务场景。通过该接口生成的小程序码，永久有效，有数量限制
    /// https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/qr-code/wxacode.get.html
    /// </summary>
    /// <param name="path">扫码进入的小程序页面路径，最大长度 128 字节，不能为空；对于小游戏，可以只传入 query 部分，来实现传参效果，如：传入 "?foo=bar"，即可在 wx.getLaunchOptionsSync 接口中的 query 参数获取到 {foo:"bar"}。</param>
    /// <param name="autoColor">自动配置线条颜色，如果颜色依然是黑色，则说明不建议配置主色调</param>
    /// <param name="lineColor">auto_color 为 false 时生效，使用 rgb 设置颜色 例如 {"r":"xxx","g":"xxx","b":"xxx"} 十进制表示</param>
    /// <param name="isHyaline">是否需要透明底色，为 true 时，生成透明底色的小程序码</param>
    /// <param name="width">二维码的宽度，单位 px。最小 280px，最大 1280px</param>
    /// <returns></returns>
    public async Task<byte[]> Get(string path, bool autoColor = false, object lineColor = null, bool isHyaline = false,
        int width = 430)
    {
        if (string.IsNullOrWhiteSpace(path)) throw new ArgumentException("参数不能为空！", nameof(path));
        return await DownloadData("wxa/getwxacode?access_token={ACCESS_TOKEN}", RestSharp.Method.POST, new
        {
            path,
            width,
            auto_color = autoColor,
            line_color = lineColor ?? new { r = 0, g = 0, b = 0 },
            is_hyaline = isHyaline
        });
    }
```
如上述代码所示，注意事项如下：

1. 通过DownloadData函数下载二维码
2. 如需使用access_token，请在Url添加access_token={ACCESS_TOKEN}【后续将进一步优化】

如需返回JSON对象，示例如下所示：

```csharp
public class SnsAppService : ServiceBase
{
    private const string ApiName = "sns";
    private readonly IMiniProgramConfig _config;

    public SnsAppService(IMiniProgramConfig config)
    {
        _config = config;
    }

    /// <summary>
    ///     根据登录凭证获取Sns信息（openid、session_key、unionid）
    /// https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/login/auth.code2Session.html
    /// </summary>
    /// <param name="code">登录时获取的 code</param>
    public async Task<GetSnsInfoByCodeOutput> JscodeToSession(string code)
    {
        if (string.IsNullOrWhiteSpace(code)) throw new ArgumentException("参数不能为空！", nameof(code));
        //获取api请求url
        var url =
            $"{ApiName}/jscode2session?appid={_config.MiniProgramAppId}&secret={_config.MiniProgramAppSecret}&js_code={code}&grant_type=authorization_code";

        return await HttpGet<GetSnsInfoByCodeOutput>(url);
    }
}
```
注意事项如下：

- 添加GetSnsInfoByCodeOutput，需继承自ServiceOutputBase

- 使用HttpGet或HttpPost方法来完成请求

- Output类中的属性请遵守C#命名规范，可以使用“JsonProperty”特性进行配置

  ```csharp
      /// <summary>
      ///     凭证有效时间，单位：秒
      /// </summary>
      [JsonProperty("expires_in")]
      public int Expires { get; set; }
  
      /// <summary>
      ///     access_token
      /// </summary>
      [JsonProperty("access_token")]
      public string AccessToken { get; set; }
  ```

### 4.编写相关单元测试，并确保通过

单元测试请参考工程【Test】和【Abp.Test】，可以通过ServiceOutputBase的IsSuccess方法来判断是否成功：

```csharp
public class TokenTest : AbpTestBase
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
```
## 官方订阅号

关注“麦扣聊技术”订阅号免费获取：

* 最新文章、教程、文档
* 视频教程
* 基础版免费授权
* 模板
* 解决方案
* 编程心得和理念

![官方订阅号](res/wechat.jpg)

## 相关QQ群

编程交流群<85318032>

产品交流群<897857351>

## 官方博客/文档站

- <http://www.cnblogs.com/codelove/>
- <https://docs.xin-lai.com/>

## 其他开源库地址

- <https://gitee.com/magicodes/Magicodes.Admin.Core>
- <https://github.com/xin-lai>


