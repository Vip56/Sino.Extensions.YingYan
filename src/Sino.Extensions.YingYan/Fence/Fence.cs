using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class Fence
    {
        /// <summary>
        /// 围栏唯一标识
        /// </summary>
        [DeserializeAs(Name = "fence_id")]
        public int FenceId { get; set; }

        /// <summary>
        /// 围栏名称
        /// </summary>
        [DeserializeAs(Name = "fence_name")]
        public string FenceName { get; set; }

        /// <summary>
        /// 围栏的监控对象
        /// </summary>
        [DeserializeAs(Name = "monitored_person")]
        public string MonitoredPerson { get; set; }

        /// <summary>
        /// 围栏的形状
        /// </summary>
        [DeserializeAs(Name = "shape")]
        public string Shape { get; set; }

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
        /// 半径
        /// </summary>
        [DeserializeAs(Name = "radius")]
        public double Radius { get; set; }

        /// <summary>
        /// 多边形围栏形状点
        /// </summary>
        [DeserializeAs(Name = "vertexes")]
        public string[] Vertexes { get; set; }

        /// <summary>
        /// 偏移距离 
        /// </summary>
        [DeserializeAs(Name = "offset")]
        public double Offset { get; set; }

        /// <summary>
        /// 返回的坐标类型
        /// </summary>
        [DeserializeAs(Name = "coord_type")]
        public string CoordType { get; set; }

        /// <summary>
        /// 围栏去噪参数
        /// </summary>
        [DeserializeAs(Name = "denoise")]
        public int Denoise { get; set; }

        /// <summary>
        /// 行政区划描述
        /// </summary>
        [DeserializeAs(Name = "district")]
        public string District { get; set; }

        /// <summary>
        /// 围栏创建时间
        /// </summary>
        [DeserializeAs(Name = "create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 围栏修改时间
        /// </summary>
        [DeserializeAs(Name = "modify_time")]
        public string ModifyTime { get; set; }
    }
}
