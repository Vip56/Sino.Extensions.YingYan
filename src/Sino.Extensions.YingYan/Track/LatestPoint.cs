using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class LatestPoint
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
        public double Katitude { get; set; }

        /// <summary>
        /// 定位时间
        /// </summary>
        [DeserializeAs(Name = "loc_time")]
        public long LocTime { get; set; }

        /// <summary>
        /// 定位精度
        /// </summary>
        [DeserializeAs(Name = "radius")]
        public double Radius { get; set; }

        /// <summary>
        /// 坐标类型
        /// </summary>
        [DeserializeAs(Name = "coord_type")]
        public string CoordType { get; set; }

        /// <summary>
        /// 方向
        /// </summary>
        [DeserializeAs(Name = "direction")]
        public int Direction { get; set; }

        /// <summary>
        /// 高度
        /// </summary>
        [DeserializeAs(Name = "height")]
        public double Height { get; set; }

        /// <summary>
        /// 速度
        /// </summary>
        [DeserializeAs(Name = "speed")]
        public double Speed { get; set; }

        /// <summary>
        /// 楼层
        /// </summary>
        [DeserializeAs(Name = "floor")]
        public string Floor { get; set; }

        /// <summary>
        /// 轨迹对应的道路等级
        /// </summary>
        [DeserializeAs(Name = "road_grade")]
        public string RoadGrade { get; set; }

        /// <summary>
        /// 轨迹对应的定位方式（鹰眼分析得出） 
        /// </summary>
        [DeserializeAs(Name = "locate_mode")]
        public string LocateMode { get; set; }

        /// <summary>
        /// 轨迹对应的交通方式（鹰眼分析得出） 
        /// </summary>
        [DeserializeAs(Name = "transport_mode")]
        public string TransportMode { get; set; }

        /// <summary>
        /// 对象数据名称
        /// </summary>
        [DeserializeAs(Name = "object_name")]
        public string ObjectName { get; set; }
    }
}
