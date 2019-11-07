using System;
using System.Collections.Generic;
using System.Text;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Magicodes.WxMiniProgram.Sdk.Installers;

namespace Magicodes.Abp.WxMiniProgram.Sdk
{
    public class WxMiniProgramSdkModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.IocContainer.Install(new WxMiniProgramSdkInstaller());

            var assembly = typeof(WxMiniProgramSdkModule).GetAssembly();
            IocManager.RegisterAssemblyByConvention(assembly);
        }
    }
}
