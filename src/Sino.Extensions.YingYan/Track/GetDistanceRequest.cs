using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class GetDistanceRequest
    {
        /// <summary>
        /// entity唯一标识 
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
        /// 是否返回纠偏后里程
        /// </summary>
        public string IsProcessed { get; set; }

        /// <summary>
        /// 纠偏选项
        /// </summary>
        public string ProcessOption { get; set; }

        /// <summary>
        /// 里程补偿方式
        /// </summary>
        public string SupplementMode { get; set; }
    }
}
