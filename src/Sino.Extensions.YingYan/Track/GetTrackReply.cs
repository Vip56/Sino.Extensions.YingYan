using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class GetTrackReply:Reply
    {
        /// <summary>
        /// 忽略掉page_index，page_size后的轨迹点数量 
        /// </summary>
        [DeserializeAs(Name = "total")]
        public int Total { get; set; }

        /// <summary>
        /// 返回的结果条数
        /// </summary>
        [DeserializeAs(Name = "size")]
        public int Size { get; set; }

        /// <summary>
        /// 此段轨迹的里程数，单位：米 
        /// </summary>
        [DeserializeAs(Name = "distance")]
        public double Distance { get; set; }

        /// <summary>
        /// 此段轨迹的收费里程数，单位：米 
        /// </summary>
        [DeserializeAs(Name = "toll_distance")]
        public double TollDistance { get; set; }

        /// <summary>
        /// 起点信息
        /// </summary>
        [DeserializeAs(Name = "start_point")]
        public StartPoint StartPoint { get; set; }

        /// <summary>
        /// 终点信息
        /// </summary>
        [DeserializeAs(Name = "end_point")]
        public EndPoint EndPoint { get; set; }

        /// <summary>
        /// 历史轨迹点列表
        /// </summary>
        [DeserializeAs(Name = "points")]
        public List<Points> Points { get; set; }
    }
}
