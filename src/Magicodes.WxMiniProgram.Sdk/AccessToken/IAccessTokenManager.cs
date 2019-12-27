// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : IAccessTokenManager.cs
//           description :
// 
//           created by 雪雁 at  2019-11-06 11:34
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

using System.Threading.Tasks;

namespace Magicodes.WxMiniProgram.Sdk.AccessToken
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAccessTokenManager
    {
        /// <summary>
        ///     获取AccessToken
        /// </summary>
        /// <returns></returns>
        Task<string> GetAccessTokenAsync();
    }
}