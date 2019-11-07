// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : WxMiniProgramSdkModule.cs
//           description :
// 
//           created by 雪雁 at  2019-11-07 9:07
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

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