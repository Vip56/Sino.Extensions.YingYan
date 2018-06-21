using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class DeleteFenceRequest: FenceRequest
    {
        /// <summary>
        /// 围栏id列表 
        /// </summary>
        public string FenceIds { get; set; }
    }
}
