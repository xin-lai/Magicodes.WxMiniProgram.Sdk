// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : AbpMiniProgramConfig.cs
//           description :
// 
//           created by 雪雁 at  2019-11-07 9:37
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

using Abp;
using Abp.Configuration;
using Abp.Dependency;
using Abp.Json;
using Magicodes.WxMiniProgram.Sdk.Configs;
using Microsoft.Extensions.Configuration;

namespace Magicodes.Abp.WxMiniProgram.Sdk
{
    public class AbpMiniProgramConfig : DefaultMiniProgramConfig, IShouldInitialize, ITransientDependency
    {
        /// <summary>
        /// </summary>
        public IIocResolver IocResolver { get; set; }

        /// <summary>
        /// </summary>
        public IConfiguration AppConfiguration { get; set; }

        protected string Key { get; set; } = "App_MiniProgram";

        /// <summary>
        ///     Implementors should perform any initialization logic.
        /// </summary>
        public void Initialize()
        {
            var config = GetConfigFromConfigOrSettingsByKey();
            MiniProgramAppId = config.MiniProgramAppId;
            MiniProgramAppSecret = config.MiniProgramAppSecret;
        }

        /// <summary>
        ///     根据key从站点配置文件或设置中获取配置
        /// </summary>
        public virtual AbpMiniProgramConfig GetConfigFromConfigOrSettingsByKey()
        {
            var settings = AppConfiguration?.GetSection(Key)?.Get<AbpMiniProgramConfig>();
            if (settings != null) return settings;

            using (var obj = IocResolver.ResolveAsDisposable<ISettingManager>())
            {
                var value = obj.Object.GetSettingValue(Key);
                if (string.IsNullOrWhiteSpace(value)) return null;
                settings = value.FromJsonString<AbpMiniProgramConfig>();
                return settings;
            }
        }
    }
}