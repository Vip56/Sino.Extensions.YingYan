using RestSharp.Deserializers;

namespace Sino.Extensions.YingYan
{
    /// <summary>
    /// 定位对象
    /// </summary>
    public class Location
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
        /// 定位时间
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
        [DeserializeAs(Name = "Floor")]
        public string Floor { get; set; }

        /// <summary>
        /// 对象数据名称
        /// </summary>
        [DeserializeAs(Name = "object_name")]
        public string ObjectName { get; set; }
    }
}
