using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class MonitoredStatuse
    {
        /// <summary>
        ///  围栏 id 
        /// </summary>
        [DeserializeAs(Name = "fence_id")]
        public int FenceId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [DeserializeAs(Name = "monitored_status")]
        public string MonitoredStatus { get; set; }
    }
}
