using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class UpdatePolylineFenceRequest: FenceRequest
    {
        /// <summary>
        /// 围栏的唯一标识
        /// </summary>
        public int FenceId { get; set; }

        /// <summary>
        /// 多边形围栏形状点
        /// </summary>
        public string[] Vertexes { get; set; }

        /// <summary>
        /// 偏离距离
        /// </summary>
        public int Offset { get; set; }

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
