using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class HarshAcceleration
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
        /// 实际加速度
        /// </summary>
        [DeserializeAs(Name = "acceleration")]
        public double Acceleration { get; set; }

        /// <summary>
        /// 加速前时速
        /// </summary>
        [DeserializeAs(Name = "initial_speed")]
        public double InitialSpeed { get; set; }

        /// <summary>
        /// 加速后时速
        /// </summary>
        [DeserializeAs(Name = "end_speed")]
        public double EndSpeed { get; set; }
    }
}
