using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Sino.Extensions.YingYan.Terminal
{
    /// <summary>
    /// 检索终端回应
    /// </summary>
    public class ListTerminalReply : Reply
    {
        /// <summary>
        /// 总结果条数
        /// </summary>
        [DeserializeAs(Name = "total")]
        public int Total { get; set; }

        /// <summary>
        /// 结果条数
        /// </summary>
        [DeserializeAs(Name = "size")]
        public int Size { get; set; }

        /// <summary>
        /// 实体数组
        /// </summary>
        [DeserializeAs(Name = "entities")]
        public List<Entity> Entities { get; set; }
    }
}
