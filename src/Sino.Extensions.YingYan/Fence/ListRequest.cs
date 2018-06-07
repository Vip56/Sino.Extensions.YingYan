using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class ListRequest: FenceRequest
    {
        public int[] FenceIds { get; set; }

        public CoordType CoordTypeOutput { get; set; }
    }
}
