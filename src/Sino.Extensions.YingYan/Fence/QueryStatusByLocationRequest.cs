using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class QueryStatusByLocationRequest
    {
        /// <summary>
        /// 监控对象的 entity_name 
        /// </summary>
        public string MonitoredPerson { get; set; }

        /// <summary>
        /// 围栏实体的id列表 
        /// </summary>
        public int[] FenceIds { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// 纬度 
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// 坐标类型
        /// </summary>
        public CoordType CoordType { get; set; }
    }
}
