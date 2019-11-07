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


