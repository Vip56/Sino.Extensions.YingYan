using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Space
{
    public class BoundSearchRequest : SpaceRequest
    {
        /// <summary>
        /// 矩形区域, 左下角和右上角的经纬度坐标点。 
        /// </summary>
        public string Bounds { get; set; }

        /// <summary>
        /// 请求参数 bounds 的坐标类型
        /// </summary>
        public CoordType CoordTypeInput { get; set; }
    }
}
