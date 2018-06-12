using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class DrivingBehaviourReply : Reply
    {
        /// <summary>
        /// 行程里程
        /// </summary>
        [DeserializeAs(Name = "distance")]
        public double Distance { get; set; }

        /// <summary>
        /// 行程耗时
        /// </summary>
        [DeserializeAs(Name = "duration")]
        public int Duration { get; set; }

        /// <summary>
        /// 平均时速
        /// </summary>
        [DeserializeAs(Name = "average_speed")]
        public double AverageSpeed { get; set; }

        /// <summary>
        /// 最高时速
        /// </summary>
        [DeserializeAs(Name = "max_speed")]
        public double MaxSpeed { get; set; }

        /// <summary>
        /// 超速次数
        /// </summary>
        [DeserializeAs(Name = "speeding_num")]
        public int SpeedingNum { get; set; }

        /// <summary>
        /// 急加速次数
        /// </summary>
        [DeserializeAs(Name = "harsh_acceleration_num")]
        public int HarshAccelerationNum { get; set; }

        /// <summary>
        /// 急刹车次数
        /// </summary>
        [DeserializeAs(Name = "harsh_breaking_num")]
        public int HarshBreakingNum { get; set; }

        /// <summary>
        /// 急转弯次数
        /// </summary>
        [DeserializeAs(Name = "harsh_steering_num")]
        public int HarshSteeringNum { get; set; }

        /// <summary>
        /// 起点信息
        /// </summary>
        [DeserializeAs(Name = "start_point")]
        public StartPoint StartPoint { get; set; }

        /// <summary>
        /// 终点信息
        /// </summary>
        [DeserializeAs(Name = "end_point")]
        public EndPoint EndPoint { get; set; }

        /// <summary>
        /// 超速记录集合
        /// </summary>
        [DeserializeAs(Name = "speeding")]
        public List<Speeding> Speeding { get; set; }

        /// <summary>
        /// 急加速记录集合
        /// </summary>
        [DeserializeAs(Name = "harsh_acceleration")]
        public List<HarshAcceleration> HarshAcceleration { get; set; }

        /// <summary>
        /// 急刹车记录集合
        /// </summary>
        [DeserializeAs(Name = "harsh_breaking")]
        public List<HarshBreaking> HarshBreaking { get; set; }

        /// <summary>
        /// 急转弯记录集合
        /// </summary>
        [DeserializeAs(Name = "harsh_steering")]
        public List<HarshSteering> HarshSteering { get; set; }
    }
}
