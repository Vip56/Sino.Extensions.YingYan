using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class GetDistanceReply:Reply
    {
        /// <summary>
        /// 轨迹里程
        /// </summary>
        [DeserializeAs(Name = "status")]
        public string Distance { get; set; }
    }
}
