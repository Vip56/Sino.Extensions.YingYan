using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class EndPoint
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
        /// 终点地址
        /// </summary>
        [DeserializeAs(Name = "address")]
        public string Address { get; set; }
    }
}
