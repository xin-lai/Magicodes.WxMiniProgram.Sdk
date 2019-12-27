// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : Extensions.cs
//           description :
//   
//           created by 雪雁 at  2019-03-13 10:37
//           Mail: wenqiang.li@xin-lai.com
//           QQ群：85318032（技术交流）
//           Blog：http://www.cnblogs.com/codelove/
//           GitHub：https://github.com/xin-lai
//           Home：http://xin-lai.com
//   
// ======================================================================

using System;

namespace Magicodes.WxMiniProgram.Sdk
{
    public static class Extensions
    {
        /// <summary>
        ///     替换字符串,支持大小写忽略
        /// </summary>
        /// <param name="source">字符串</param>
        /// <param name="oldString">需要替换的字符串</param>
        /// <param name="newString">新字符串</param>
        /// <param name="comp"></param>
        /// <returns></returns>
        public static string Replace(this string source, string oldString, string newString,
            StringComparison comp = StringComparison.CurrentCultureIgnoreCase)
        {
            var index = source.IndexOf(oldString, comp);

            var matchFound = index >= 0;

            if (matchFound)
            {
                source = source.Remove(index, oldString.Length);
                source = source.Insert(index, newString);
            }

            if (source.IndexOf(oldString, comp) != -1) source = Replace(source, oldString, newString, comp);
            return source;
        }
    }
}