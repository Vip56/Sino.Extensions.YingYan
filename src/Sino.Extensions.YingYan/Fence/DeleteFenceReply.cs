using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class DeleteFenceReply: Reply
    {
        [DeserializeAs(Name = "fence_ids")]
        public int[] FenceIds { get; set; }
    }
}
