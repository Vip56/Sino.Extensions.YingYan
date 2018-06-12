using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class StayPointReply : Reply
    {
        /// <summary>
        /// 停留次数
        /// </summary>
        [DeserializeAs(Name = "staypoint_num")]
        public int StaypointNum { get; set; }

        /// <summary>
        /// 停留记录列表
        /// </summary>
        [DeserializeAs(Name = "stay_points")]
        public List<StayPoints> StayPoints { get; set; }
    }
}
