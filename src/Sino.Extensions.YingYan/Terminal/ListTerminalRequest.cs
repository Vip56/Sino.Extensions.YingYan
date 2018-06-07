using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Terminal
{
    /// <summary>
    /// 检索终端请求
    /// </summary>
    public class ListTerminalRequest
    {
        /// <summary>
        /// 按照名称检索
        /// </summary>
        public List<string> Names { get; set; }

        /// <summary>
        /// 查询在此时间之后有定位信息的终端
        /// </summary>
        public DateTime ActiveTime { get; set; }

        /// <summary>
        /// 查询在此时间之后无定位信息的终端
        /// </summary>
        public DateTime InactiveTime { get; set; }

        /// <summary>
        /// 开发者自定义参数检索
        /// </summary>
        public Dictionary<string, string> ExtFilter { get; set; }

        /// <summary>
        /// 坐标类型
        /// </summary>
        public CoordType CoordType { get; set; }

        /// <summary>
        /// 分页索引
        /// </summary>
        public int Index { get; set; } = 0;

        /// <summary>
        /// 分页大小
        /// </summary>
        public int Size { get; set; } = 10;
    }
}
