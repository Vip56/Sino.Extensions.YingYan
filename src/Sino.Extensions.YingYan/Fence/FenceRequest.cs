using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class FenceRequest
    {
        /// <summary>
        /// 围栏名称 是否必填 否
        /// </summary>
        public string FenceName { get; set; }

        /// <summary>
        /// 监控对象 是否必填 否
        /// </summary>
        public string MonitoredPerson { get; set; }
    }
}
