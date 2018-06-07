using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class BatchHistoryAlarmReply: Reply
    {
        /// <summary>
        /// 符合条件的总报警数
        /// </summary>
        [DeserializeAs(Name = "total")]
        public int Total { get; set; }

        /// <summary>
        /// 本页返回的结果条数
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
