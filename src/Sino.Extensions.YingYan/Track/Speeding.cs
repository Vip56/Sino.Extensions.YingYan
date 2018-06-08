using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class Speeding
    {
        /// <summary>
        /// 超速里程
        /// </summary>
        [DeserializeAs(Name = "speeding_distance")]
        public double speeding_distance { get; set; }

        /// <summary>
        /// 超速点
        /// </summary>
        [DeserializeAs(Name = "speeding_points")]
        public List<SpeedingPoints> SpeedingPoints { get; set; }
    }
}
