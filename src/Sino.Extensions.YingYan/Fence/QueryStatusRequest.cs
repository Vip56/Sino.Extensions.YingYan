using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class QueryStatusRequest
    {
        /// <summary>
        /// 监控对象的 entity_name 
        /// </summary>
        public string MonitoredPerson { get; set; }

        /// <summary>
        /// 围栏实体的id列表
        /// </summary>
        public string FenceIds { get; set; }
    }
}
