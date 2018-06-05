using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Terminal
{
    /// <summary>
    /// 添加终端请求
    /// </summary>
    public class AddTerminalRequest
    {
        /// <summary>
        /// 终端名称，唯一标识
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
    }
}
