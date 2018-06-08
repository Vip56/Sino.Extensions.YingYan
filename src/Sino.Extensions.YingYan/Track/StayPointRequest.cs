using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class StayPointRequest
    {
        /// <summary>
        /// entity名称，作为其唯一标识
        /// </summary>
        public string EntityName { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public long StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public long EndTime { get; set; }

        /// <summary>
        /// 停留时间
        /// </summary>
        public int StayTime { get; set; }

        /// <summary>
        /// 停留半径
        /// </summary>
        public int StayRadius { get; set; }

        /// <summary>
        /// 纠偏选项，用于控制返回坐标的纠偏处理方式 
        /// </summary>
        public string ProcessOption { get; set; }

        /// <summary>
        /// 返回的坐标类型
        /// </summary>
        public CoordType CoordTypeOutput { get; set; }
    }
}
