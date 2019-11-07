using System.Threading.Tasks;

namespace Magicodes.WxMiniProgram.Sdk.AccessToken
{
    public interface IAccessTokenManager
    {
        /// <summary>
        /// 获取AccessToken
        /// </summary>
        /// <returns></returns>
        Task<string> GetAccessTokenAsync();

        /// <summary>
        /// 获取AccessToken
        /// </summary>
        /// <returns></returns>
        string GetAccessToken();
    }
}
