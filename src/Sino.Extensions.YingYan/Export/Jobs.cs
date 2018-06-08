using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Export
{
    public class Jobs
    {
        /// <summary>
        /// 任务id 
        /// </summary>
        [DeserializeAs(Name = "job_id")]
        public int JobId { get; set; }

        /// <summary>
        /// 轨迹起始时间
        /// </summary>
        [DeserializeAs(Name = "start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// 轨迹结束时间
        /// </summary>
        [DeserializeAs(Name = "end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 返回的坐标类型
        /// </summary>
        [DeserializeAs(Name = "coord_type_output")]
        public string CoordTypeOutput { get; set; }

        /// <summary>
        /// 任务创建的格式化时间
        /// </summary>
        [DeserializeAs(Name = "create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 任务创建的格式化时间
        /// </summary>
        [DeserializeAs(Name = "modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 任务当前的执行状态
        /// </summary>
        [DeserializeAs(Name = "job_status")]
        public string JobStatus { get; set; }

        /// <summary>
        /// 轨迹数据文件下载链接
        /// </summary>
        [DeserializeAs(Name = "file_url")]
        public string FileUrl { get; set; }
    }
}
