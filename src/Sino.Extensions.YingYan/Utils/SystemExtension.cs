using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public static class SystemExtension
    {
        /// <summary>
        /// 获取Unix时间戳
        /// </summary>
        public static long ToUnixTime(this DateTime dt)
        {
            TimeSpan ts = dt - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds);
        }
    }
}
