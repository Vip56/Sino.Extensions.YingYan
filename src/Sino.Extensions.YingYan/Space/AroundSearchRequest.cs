using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Space
{
    public class AroundSearchRequest:SpaceRequest
    {
        /// <summary>
        /// 中心点经纬度
        /// </summary>
        public string Center { get; set; }

        /// <summary>
        /// 搜索半径
        /// </summary>
        public int Radius { get; set; }

        /// <summary>
        /// 请求参数 center 的坐标类型 
        /// </summary>
        public CoordType CoordTypeInput { get; set; }
    }
}
