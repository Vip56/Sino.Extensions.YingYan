using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Sino.Extensions.YingYan
{
    /// <summary>
    /// 坐标类型
    /// </summary>
    public enum CoordType
    {
        /// <summary>
        /// 百度
        /// </summary>
        [Description("bd09ll")]
        BD09ll,
        /// <summary>
        /// 国测局加密坐标
        /// </summary>
        [Description("gcj02")]
        GCJ02,
        /// <summary>
        /// 国际标准
        /// </summary>
        [Description("wgs84")]
        WGS84
    }
}
