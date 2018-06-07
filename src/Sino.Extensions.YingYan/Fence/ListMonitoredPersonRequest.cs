using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class ListMonitoredPersonRequest
    {
        /// <summary>
        /// 围栏id
        /// </summary>
        public int FenceId { get; set; }

        /// <summary>
        /// 分页索引
        /// </summary>
        public int PageIndex { get; set; } = 1;

        /// <summary>
        /// 分页大小 
        /// </summary>
        public int PageSize { get; set; } = 100;
    }
}
