using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class FenceReply: Reply
    {
        /// <summary>
        /// 围栏的唯一标识
        /// </summary>
        [DeserializeAs(Name = "fence_id")]
        public int FenceId { get; set; }
    }
}
