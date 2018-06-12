using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class AlarmPoint
    {
        /// <summary>
        ///  监控对象触发围栏时的经度 
        /// </summary>
        [DeserializeAs(Name = "longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// 监控对象触发围栏时的纬度 
        /// </summary>
        [DeserializeAs(Name = "latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// 定位精度
        /// </summary>
        [DeserializeAs(Name = "radius")]
        public int Radius { get; set; }

        /// <summary>
        /// 返回的坐标类型
        /// </summary>
        [DeserializeAs(Name = "coord_type")]
        public string CoordType { get; set; }

        /// <summary>
        /// 围栏实际触发时间，即触发围栏报警的轨迹点的定位时间
        /// </summary>
        [DeserializeAs(Name = "loc_time")]
        public long LocTime { get; set; }

        /// <summary>
        /// 服务端接收到报警信息的时间
        /// </summary>
        [DeserializeAs(Name = "create_time")]
        public long CreateTime { get; set; }
    }
}
