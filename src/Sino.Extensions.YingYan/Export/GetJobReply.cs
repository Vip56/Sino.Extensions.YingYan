using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Export
{
    public class GetJobReply : Reply
    {

        /// <summary>
        /// 任务总条数
        /// </summary>
        [DeserializeAs(Name = "total")]
        public int Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DeserializeAs(Name = "jobs")]
        public List<Jobs> Jobs { get; set; }
    }
}
