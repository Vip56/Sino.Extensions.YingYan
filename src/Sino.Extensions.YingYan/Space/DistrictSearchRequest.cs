using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Space
{
    public class DistrictSearchRequest:SpaceRequest
    {
        /// <summary>
        /// 行政区划关键字
        /// </summary>
        public string KeyWord { get; set; }

        /// <summary>
        /// 设置返回值的内容
        /// </summary>
        public string ReturnType { get; set; }
    }
}
