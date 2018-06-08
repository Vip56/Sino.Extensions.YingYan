using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Space
{
    public class SpaceReply: Reply
    {
        /// <summary>
        /// 本次检索总结果条数 
        /// </summary>
        [DeserializeAs(Name = "total")]
        public int Total { get; set; }

        /// <summary>
        /// 本页返回的结果条数 
        /// </summary>
        [DeserializeAs(Name = "size")]
        public int Size { get; set; }

        /// <summary>
        /// entity详细信息列表
        /// </summary>
        [DeserializeAs(Name = "entities")]
        public List<Entitie> Entities { get; set; }
    }
}
