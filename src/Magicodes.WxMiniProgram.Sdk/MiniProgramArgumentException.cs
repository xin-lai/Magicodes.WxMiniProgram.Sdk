// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : MiniProgramArgumentException.cs
//           description :
// 
//           created by 雪雁 at  2019-11-04 15:27
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

using System;

namespace Magicodes.WxMiniProgram.Sdk
{
    /// <summary>
    ///     接口参数异常
    /// </summary>
    public class MiniProgramArgumentException : ArgumentException
    {
        public MiniProgramArgumentException()
        {
        }

        public MiniProgramArgumentException(string message) : base(message)
        {
        }

        public MiniProgramArgumentException(string message, string paramName) : base(message, paramName)
        {
        }
    }
}