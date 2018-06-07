using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class CreateCircleFenceRequest: FenceRequest
    {
        /// <summary>
        /// 围栏圆心经度
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// 围栏圆心纬度 
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// 围栏半径 
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// 坐标类型
        /// </summary>
        public CoordType CoordType { get; set; }

        /// <summary>
        /// 围栏去噪参数 是否必填 否
        /// </summary>
        public int Denoise { get; set; }
    }
}
