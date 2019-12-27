// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : WxMiniProgramSdkInstaller.cs
//           description :
// 
//           created by 雪雁 at  2019-11-06 11:25
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

using System.Net.Http;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Magicodes.WxMiniProgram.Sdk.AccessToken;
using Magicodes.WxMiniProgram.Sdk.Services;

namespace Magicodes.WxMiniProgram.Sdk.Installers
{
    /// <summary>
    /// 
    /// </summary>
    public class WxMiniProgramSdkInstaller : IWindsorInstaller
    {
        /// <summary>
        ///     Performs the installation in the <see cref="T:Castle.Windsor.IWindsorContainer" />.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <param name="store">The configuration store.</param>
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                //注册AccessToken管理器
                Component.For<IAccessTokenManager>().ImplementedBy<AccessTokenManager>().LifestyleSingleton(),
                //注册所有的服务
                Classes.FromAssembly(typeof(WxMiniProgramSdkInstaller).Assembly)
                    .BasedOn<ServiceBase>()
                    .LifestyleTransient()
            );
        }
    }
}