using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Space
{
    public class DistrictSearchReply:SpaceReply
    {
        /// <summary>
        /// 关键字匹配的行政区划列表
        /// </summary>
        [DeserializeAs(Name = "district_list")]
        public string[] DistrictList { get; set; }
    }
}
