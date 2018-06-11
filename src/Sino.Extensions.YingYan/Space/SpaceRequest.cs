using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Space
{
    public class SpaceRequest
    {
        /// <summary>
        /// 过滤条件
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// 排序方法
        /// </summary>
        public string Sortby { get; set; }

        /// <summary>
        /// 返回结果的坐标类型
        /// </summary>
        public CoordType CoordTypeOutput { get; set; }

        /// <summary>
        /// 分页索引
        /// </summary>
        public int PageIndex { get; set; } = 1;

        /// <summary>
        /// 分页大小
        /// </summary>
        public int PageSize { get; set; } = 100;
    }
}
