using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class AddPointRequest
    {
        /// <summary>
        /// entity唯一标识 
        /// </summary>
        public string EntityName { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// 定位时设备的时间
        /// </summary>
        public long LocTime { get; set; }

        /// <summary>
        /// 坐标类型
        /// </summary>
        public CoordType CoordTypeInput { get; set; } = CoordType.BD09ll;

        /// <summary>
        /// 速度
        /// </summary>
        public double Speed { get; set; }

        /// <summary>
        /// 方向
        /// </summary>
        public int Direction { get; set; }

        /// <summary>
        /// 高度
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// 定位精度，GPS或定位SDK返回的值
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// 对象数据名称
        /// </summary>
        public string ObjectName { get; set; }

        /// <summary>
        /// 开发者自定义字段
        /// </summary>
        public Dictionary<string, string> Ext { get; set; }
    }
}
