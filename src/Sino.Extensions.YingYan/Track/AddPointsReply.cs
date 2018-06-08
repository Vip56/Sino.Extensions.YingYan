using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class AddPointsReply:Reply
    {
        /// <summary>
        /// 上传成功的点个数
        /// </summary>
        [DeserializeAs(Name = "success_num")]
        public int SuccessNum { get; set; }

        /// <summary>
        /// 上传失败的点信息
        /// </summary>
        [DeserializeAs(Name = "fail_info")]
        public FailInfo FailInfo { get; set; }
    }
}
