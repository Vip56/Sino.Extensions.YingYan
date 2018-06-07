using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Fence
{
    public class CreateDistrictFenceReply : FenceReply
    {
        /// <summary>
        /// 结构化的行政区划描述
        /// </summary>
        [DeserializeAs(Name = "fence_id")]
        public string District { get; set; }

        /// <summary>
        /// 关键字匹配的行政区划列表
        /// </summary>
        [DeserializeAs(Name = "district_list")]
        public string[] DistrictList { get; set; }
    }
}
