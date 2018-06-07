using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class Alarm
    {
        /// <summary>
        ///  围栏 id，唯一标识符
        /// </summary>
        [DeserializeAs(Name = "fence_id")]
        public int FenceId { get; set; }

        /// <summary>
        /// 围栏的名称
        /// </summary>
        [DeserializeAs(Name = "fence_name")]
        public string FenceName { get; set; }

        /// <summary>
        /// 监控对象
        /// </summary>
        [DeserializeAs(Name = "monitored_person")]
        public string MonitoredPerson { get; set; }

        /// <summary>
        /// 触发动作
        /// </summary>
        [DeserializeAs(Name = "action")]
        public string Action { get; set; }

        /// <summary>
        /// 触发围栏报警轨迹点
        /// </summary>
        [DeserializeAs(Name = "alarm_point")]
        public AlarmPoint AlarmPoint { get; set; }

        /// <summary>
        /// 触发围栏报警轨迹点的上一个轨迹点
        /// </summary>
        [DeserializeAs(Name = "pre_point")]
        public PrePoint PrePoint { get; set; }
    }
}
