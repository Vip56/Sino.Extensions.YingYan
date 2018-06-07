using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class CreatePolygonFenceRequest: FenceRequest
    {
        /// <summary>
        /// 多边形围栏形状点
        /// </summary>
        public string[] Vertexes { get; set; }

        /// <summary>
        /// 坐标类型
        /// </summary>
        public CoordType CoordType { get; set; }

        /// <summary>
        /// 围栏去噪参数
        /// </summary>
        public int Denoise { get; set; }
    }
}
