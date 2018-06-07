using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class QueryStatusReply:Reply
    {
        /// <summary>
        /// 返回结果的数量
        /// </summary>
        [DeserializeAs(Name = "size")]
        public int Size { get; set; }

        /// <summary>
        /// 报警的数量
        /// </summary>
        [DeserializeAs(Name = "monitored_statuses")]
        public List<MonitoredStatuse> MonitoredStatuses { get; set; }
    }
}
