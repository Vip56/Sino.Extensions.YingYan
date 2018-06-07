using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class HistoryAlarmReply: Reply
    {
        /// <summary>
        /// 返回结果的数量
        /// </summary>
        [DeserializeAs(Name = "size")]
        public int Size { get; set; }

        /// <summary>
        /// 报警的数量 
        /// </summary>
        [DeserializeAs(Name = "alarms")]
        public List<Alarm> Alarms { get; set; }
    }
}
