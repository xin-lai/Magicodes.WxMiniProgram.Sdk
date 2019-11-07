// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : TestModule.cs
//           description :
// 
//           created by 雪雁 at  2019-11-07 9:49
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

using System.IO;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Test.DependencyInjection;
using Abp.TestBase;
using Castle.MicroKernel.Registration;
using Magicodes.Abp.WxMiniProgram.Sdk;
using Microsoft.Extensions.Configuration;

namespace Abp.Test
{
    [DependsOn(
        typeof(AbpTestBaseModule),
        typeof(WxMiniProgramSdkModule)
    )]
    public class TestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IocManager.IocContainer.Register(
                Component.For<IConfiguration>().Instance(GetConfiguration()).LifestyleSingleton()
            );

            //IocManager.Register<IConfiguration>();
        }

        public override void Initialize()
        {
            ServiceCollectionRegistrar.Register(IocManager);
            IocManager.RegisterAssemblyByConvention(typeof(TestModule).GetAssembly());
        }

        private static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true);

            return builder.Build();
        }
    }
}