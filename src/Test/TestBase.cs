using System;
using System.Collections.Generic;
using System.Text;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Magicodes.WxMiniProgram.Sdk.Configs;
using Magicodes.WxMiniProgram.Sdk.Installers;

namespace Test
{
    public class TestBase
    {
        protected IWindsorContainer Container { get; set; }

        public TestBase()
        {
            Container = new WindsorContainer();
            Container.Install(new WxMiniProgramSdkInstaller());

            //设置配置
            Container.Register(
                Component.For<IMiniProgramConfig>()
                    .Instance(new DefaultMiniProgramConfig()
                    {
                        MiniProgramAppId = "wx25fa5d55ef27e086",
                        MiniProgramAppSecret = "ab02ac4499c9764108a78e19476d7101"
                    })
                    .LifeStyle.Singleton
            );


        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Resolve<T>() => Container.Resolve<T>();
    }
}
