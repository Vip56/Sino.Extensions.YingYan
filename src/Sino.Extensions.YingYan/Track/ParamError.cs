using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public  class ParamError
    {
        /// <summary>
        /// entity唯一标识 
        /// </summary>
        [DeserializeAs(Name = "entity_name")]
        public string EntityName { get; set; }

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
        /// 定位时设备的时间
        /// </summary>
        [DeserializeAs(Name = "loc_time")]
        public long LocTime { get; set; }

        /// <summary>
        /// 坐标类型
        /// </summary>
        [DeserializeAs(Name = "coord_type_input")]
        public string CoordTypeInput { get; set; }

        /// <summary>
        /// 速度
        /// </summary>
        [DeserializeAs(Name = "speed")]
        public double Speed { get; set; }

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
        /// 定位精度，GPS或定位SDK返回的值
        /// </summary>
        [DeserializeAs(Name = "radius")]
        public double Radius { get; set; }

        /// <summary>
        /// 对象数据名称
        /// </summary>
        [DeserializeAs(Name = "object_name")]
        public string ObjectName { get; set; }

        /// <summary>
        /// 开发者自定义字段
        /// </summary>
        [DeserializeAs(Name = "ext")]
        public Dictionary<string, string> Ext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DeserializeAs(Name = "error")]
        public string Error { get; set; }
    }
}
