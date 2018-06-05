using System.Collections.Generic;

namespace Sino.Extensions.YingYan.Terminal
{
    /// <summary>
    /// 更新终端请求
    /// </summary>
    public class UpdateTerminalRequest
    {
        /// <summary>
        /// 名称，唯一标识
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 可读性描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 开发者自定义字段
        /// </summary>
        public Dictionary<string, string> Ext { get; set; }

        /// <summary>
        /// 返回坐标类型
        /// </summary>
        public CoordType CoordType { get; set; }

        /// <summary>
        /// 分页索引
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        public int Size { get; set; }
    }
}
