using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class BatchHistoryAlarmRequest
    {
        public long StartTime { get; set; }

        public long EndTime { get; set; }

        public CoordType CoordTypeOutput { get; set; }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }
    }
}
