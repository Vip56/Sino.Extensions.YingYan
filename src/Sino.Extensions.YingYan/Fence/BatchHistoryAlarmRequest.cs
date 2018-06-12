using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class BatchHistoryAlarmRequest
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        public long StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public long EndTime { get; set; }

        /// <summary>
        /// 返回坐标类型
        /// </summary>
        public CoordType CoordTypeOutput { get; set; }

        /// <summary>
        /// 分页索引
        /// </summary>
        public int PageIndex { get; set; } = 1;

        /// <summary>
        /// 分页大小
        /// </summary>
        public int PageSize { get; set; } = 100;
    }
}
