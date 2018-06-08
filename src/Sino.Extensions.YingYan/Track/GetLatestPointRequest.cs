using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class GetLatestPointRequest
    {
        /// <summary>
        /// entity唯一标识
        /// </summary>
        public string EntityName { get; set; }

        /// <summary>
        /// 纠偏选项
        /// </summary>
        public string ProcessOption { get; set; }

        /// <summary>
        /// 返回的坐标类型
        /// </summary>
        public CoordType CoordTypeOutput { get; set; }
    }
}
