using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Space
{
    public class PolygonSearchRequest : SpaceRequest
    {
        /// <summary>
        /// 多边形围栏形状点
        /// </summary>
        public string[] Vertexes { get; set; }

        /// <summary>
        /// 请求参数 center 的坐标类型 
        /// </summary>
        public CoordType CoordTypeInput { get; set; }
    }
}
