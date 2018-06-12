using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class CreateDistrictFenceRequest : FenceRequest
    {
        /// <summary>
        /// 行政区划关键字
        /// </summary>
        public string KeyWord { get; set; }

        /// <summary>
        /// 围栏去噪参数
        /// </summary>
        public string Denoise { get; set; }
    }
}
