using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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
        /// 
        /// </summary>
        public IIocResolver IocResolver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IConfiguration AppConfiguration { get; set; }

        /// <summary>
        ///   Implementors should perform any initialization logic.
        /// </summary>
        public void Initialize()
        {
            var config = GetConfigFromConfigOrSettingsByKey();
            this.MiniProgramAppId = config.MiniProgramAppId;
            this.MiniProgramAppSecret = config.MiniProgramAppSecret;
        }

        /// <summary>
        /// 根据key从站点配置文件或设置中获取配置
        /// </summary>
        public virtual AbpMiniProgramConfig GetConfigFromConfigOrSettingsByKey()
        {
            var settings = AppConfiguration?.GetSection(key: Key)?.Get<AbpMiniProgramConfig>();
            if (settings != null) return settings;

            using (var obj = IocResolver.ResolveAsDisposable<ISettingManager>())
            {
                var value = obj.Object.GetSettingValue(Key);
                if (string.IsNullOrWhiteSpace(value))
                {
                    return null;
                }
                settings = value.FromJsonString<AbpMiniProgramConfig>();
                return settings;
            }
        }

        protected string Key { get; set; } = "App_MiniProgram";
    }
}
