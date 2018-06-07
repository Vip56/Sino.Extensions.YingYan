using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class HistoryAlarmRequest
    {
        /// <summary>
        /// 监控对象的 entity_name 
        /// </summary>
        public string MonitoredPerson { get; set; }

        /// <summary>
        /// 围栏实体的id列表 
        /// </summary>
        public int[] FenceIds { get; set; }

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
    }
}
