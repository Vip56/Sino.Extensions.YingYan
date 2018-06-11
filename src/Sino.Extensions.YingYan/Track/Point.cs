using Newtonsoft.Json;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class Point
    {
        /// <summary>
        /// entity唯一标识 
        /// </summary>
        [JsonProperty(PropertyName = "entity_name")]
        public string EntityName { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// 定位时设备的时间
        /// </summary>
        [JsonProperty(PropertyName = "loc_time")]
        public long LocTime { get; set; }

        /// <summary>
        /// 坐标类型
        /// </summary>
        [JsonProperty(PropertyName = "coord_type_input")]
        public string CoordTypeInput { get; set; }

        /// <summary>
        /// 速度
        /// </summary>
        [JsonProperty(PropertyName = "speed")]
        public double Speed { get; set; }

        /// <summary>
        /// 方向
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        public int Direction { get; set; }

        /// <summary>
        /// 高度
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public double Height { get; set; }

        /// <summary>
        /// 定位精度，GPS或定位SDK返回的值
        /// </summary>
        [JsonProperty(PropertyName = "radius")]
        public double Radius { get; set; }

        /// <summary>
        /// 对象数据名称
        /// </summary>
        [JsonProperty(PropertyName = "object_name")]
        public string ObjectName { get; set; }

        /// <summary>
        /// 开发者自定义字段
        /// </summary>
        //public Dictionary<string, string> Ext { get; set; }
    }
}
