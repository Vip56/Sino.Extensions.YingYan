using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class ListMonitoredPersonReply: Reply
    {
        /// <summary>
        /// 查询监控entity的总个数 
        /// </summary>
        [DeserializeAs(Name = "total")]
        public int Total { get; set; }

        /// <summary>
        /// 本页返回的entity个数 
        /// </summary>
        [DeserializeAs(Name = "size")]
        public int Size { get; set; }

        /// <summary>
        /// entity列表
        /// </summary>
        [DeserializeAs(Name = "monitored_person")]
        public string[] MonitoredPerson { get; set; }
    }
}
