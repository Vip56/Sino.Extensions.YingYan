using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class StayPoints
    {
        /// <summary>
        /// 停留开始时间
        /// </summary>
        [DeserializeAs(Name = "start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// 停留结束时间
        /// </summary>
        [DeserializeAs(Name = "end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 停留时长
        /// </summary>
        [DeserializeAs(Name = "duration")]
        public int Duration { get; set; }

        /// <summary>
        /// 停留点
        /// </summary>
        [DeserializeAs(Name = "stay_point")]
        public StayPoint StayPoint { get; set; }
    }
}
