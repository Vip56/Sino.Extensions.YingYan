using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class ListFenceReply: Reply
    {
        /// <summary>
        /// 满足条件并返回的围栏个数s
        /// </summary>
        [DeserializeAs(Name = "size")]
        public int Size { get; set; }

        /// <summary>
        /// 围栏列表
        /// </summary>
        [DeserializeAs(Name = "fences")]
        public List<Fence> Fences { get; set; }
    }
}
