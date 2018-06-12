using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Export
{
    public class CreateJobReply : Reply
    {
        /// <summary>
        /// 任务 id 
        /// </summary>
        [DeserializeAs(Name = "job_id")]
        public int JobId { get; set; }
    }
}
