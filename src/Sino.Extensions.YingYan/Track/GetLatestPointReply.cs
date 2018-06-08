using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class GetLatestPointReply:Reply
    {
        /// <summary>
        /// 实时位置信息
        /// </summary>
        [DeserializeAs(Name = "latest_point")]
        public LatestPoint LatestPoint { get; set; }

        /// <summary>
        /// 轨迹对应的道路限速
        /// </summary>
        [DeserializeAs(Name = "limit_speed")]
        public double LimitSpeed { get; set; }
    }
}
