// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : TestBase.cs
//           description :
// 
//           created by 雪雁 at  2019-11-06 11:38
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Magicodes.WxMiniProgram.Sdk.Configs;
using Magicodes.WxMiniProgram.Sdk.Installers;

namespace Test
{
    public class TestBase
    {
        public TestBase()
        {
            Container = new WindsorContainer();
            Container.Install(new WxMiniProgramSdkInstaller());

            //设置配置
            Container.Register(
                Component.For<IMiniProgramConfig>()
                    .Instance(new DefaultMiniProgramConfig
                    {
                        MiniProgramAppId = "wx25fa5d55ef27e086",
                        MiniProgramAppSecret = "ab02ac4499c9764108a78e19476d7101"
                    })
                    .LifeStyle.Singleton
            );
        }

        protected IWindsorContainer Container { get; set; }

        /// <summary>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}