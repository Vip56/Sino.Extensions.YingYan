using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class HarshSteering
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
        /// 向心加速度
        /// </summary>
        [DeserializeAs(Name = "centripetal_acceleration")]
        public double CentripetalAcceleration { get; set; }

        /// <summary>
        /// 转向类型
        /// </summary>
        [DeserializeAs(Name = "turn_type")]
        public string TurnType { get; set; }

        /// <summary>
        /// 转向时速
        /// </summary>
        [DeserializeAs(Name = "speed")]
        public double Speed { get; set; }
    }
}
