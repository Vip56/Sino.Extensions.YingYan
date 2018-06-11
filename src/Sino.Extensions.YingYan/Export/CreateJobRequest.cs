using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Export
{
    public class CreateJobRequest
    {
        /// <summary>
        /// 轨迹起始时间
        /// </summary>
        public long StartTime { get; set; }

        /// <summary>
        /// 轨迹结束时间
        /// </summary>
        public long EndTime { get; set; }

        /// <summary>
        /// 返回的坐标类型
        /// </summary>
        public CoordType CoordTypeOutput { get; set; }
    }
}
