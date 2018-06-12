using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class DrivingBehaviourRequest
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
        /// 固定限速值
        /// </summary>
        public double SpeedingThreshold { get; set; }

        /// <summary>
        /// 急加速的加速度阈值 
        /// </summary>
        public double HarshAccelerationThreshold { get; set; } = 1.67;

        /// <summary>
        /// 急减速的加速度阈值 
        /// </summary>
        public double HarshBreakingThreshold { get; set; } = -1.67;

        /// <summary>
        /// 急转弯的向心加速度阈值
        /// </summary>
        public double HarshSteeringThreshold { get; set; } = 5;

        /// <summary>
        /// 纠偏选项，用于控制返回坐标的纠偏处理方式，不填则按默认纠偏方式处理 
        /// </summary>
        public string ProcessOption { get; set; }

        /// <summary>
        /// 返回的坐标类型
        /// </summary>
        public CoordType CoordTypeOutput { get; set; }
    }
}
