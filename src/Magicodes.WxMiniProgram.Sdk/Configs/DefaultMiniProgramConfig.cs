// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : DefaultMiniProgramConfig.cs
//           description :
// 
//           created by 雪雁 at  2019-11-06 11:36
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

namespace Magicodes.WxMiniProgram.Sdk.Configs
{
    /// <inheritdoc />
    public class DefaultMiniProgramConfig : IMiniProgramConfig
    {
        /// <summary>
        ///     小程序ID
        /// </summary>
        public string MiniProgramAppId { get; set; }

        /// <summary>
        ///     小程序密钥
        /// </summary>
        public string MiniProgramAppSecret { get; set; }
    }
}