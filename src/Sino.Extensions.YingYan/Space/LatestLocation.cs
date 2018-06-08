using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Space
{
    public class LatestLocation
    {
        /// <summary>
        /// 纬度
        /// </summary>
        [DeserializeAs(Name = "latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// 经度 
        /// </summary>
        [DeserializeAs(Name = "longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// 定位精度 
        /// </summary>
        [DeserializeAs(Name = "radius")]
        public double Radius { get; set; }

        /// <summary>
        /// 该entity最新定位时间 
        /// </summary>
        [DeserializeAs(Name = "loc_time")]
        public long LocTime { get; set; }

        /// <summary>
        /// 方向 
        /// </summary>
        [DeserializeAs(Name = "direction")]
        public int Direction { get; set; }

        /// <summary>
        /// 速度 
        /// </summary>
        [DeserializeAs(Name = "speed")]
        public double Speed { get; set; }

        /// <summary>
        /// 高度 
        /// </summary>
        [DeserializeAs(Name = "height")]
        public double Height { get; set; }

        /// <summary>
        /// 楼层 
        /// </summary>
        [DeserializeAs(Name = "floor")]
        public string Floor { get; set; }

        /// <summary>
        /// 距中心点距离
        /// </summary>
        [DeserializeAs(Name = "distance")]
        public double Distance { get; set; }

        /// <summary>
        /// 对象数据名称 
        /// </summary>
        [DeserializeAs(Name = "object_name")]
        public string ObjectName { get; set; }

        /// <summary>
        /// 开发者自定义track的属性
        /// </summary>
        [DeserializeAs(Name = "column-key")]
        public long ColumnKey  { get; set; }
    }
}
