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