using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class SpeedingPoints
    {
        /// <summary>
        /// 经度
        /// </summary>
        [DeserializeAs(Name = "longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [DeserializeAs(Name = "latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// 坐标类型
        /// </summary>
        [DeserializeAs(Name = "coord_type")]
        public string CoordType { get; set; }

        /// <summary>
        /// 定位时间
        /// </summary>
        [DeserializeAs(Name = "loc_time")]
        public long LocTime { get; set; }

        /// <summary>
        /// 实际行驶时速
        /// </summary>
        [DeserializeAs(Name = "actual_speed")]
        public double ActualSpeed { get; set; }

        /// <summary>
        /// 所在道路限定最高时速
        /// </summary>
        [DeserializeAs(Name = "limit_speed")]
        public double LimitSpeed { get; set; }
    }
}
