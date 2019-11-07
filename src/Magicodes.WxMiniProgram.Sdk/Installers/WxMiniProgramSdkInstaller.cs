using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Magicodes.WxMiniProgram.Sdk.AccessToken;
using Magicodes.WxMiniProgram.Sdk.Configs;
using Magicodes.WxMiniProgram.Sdk.Http;
using Magicodes.WxMiniProgram.Sdk.Services;

namespace Magicodes.WxMiniProgram.Sdk.Installers
{
    public class WxMiniProgramSdkInstaller : IWindsorInstaller
    {
        /// <summary>
        ///   Performs the installation in the <see cref="T:Castle.Windsor.IWindsorContainer" />.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <param name="store">The configuration store.</param>
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                //注册微信HttpClient
                Component.For<HttpClient>().Named(nameof(WxHttpClient)).ImplementedBy<WxHttpClient>().LifestyleSingleton(),
                //注册AccessToken管理器
                Component.For<IAccessTokenManager>().ImplementedBy<AccessTokenManager>().LifestyleSingleton(),
                //注册所有的服务
                Classes.FromAssembly(typeof(WxMiniProgramSdkInstaller).Assembly)
                    .BasedOn<ServiceBase>()
                    .LifestyleTransient()
                );

            //container.Register(
            //    Component.For<IWindsorContainer>()
            //        .Instance(container)
            //        .LifeStyle.Singleton
            //);
        }
    }
}
