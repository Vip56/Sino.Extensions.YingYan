using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class DeleteMonitoredPersonRequest
    {
        /// <summary>
        /// 围栏的唯一标识
        /// </summary>
        public int FenceId { get; set; }

        /// <summary>
        /// 监控对象
        /// </summary>
        public string MonitoredPerson { get; set; }
    }
}
