using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Track
{
    public class FailInfo
    {
        /// <summary>
        /// 输入参数不正确导致的上传失败的点 
        /// </summary>
        [DeserializeAs(Name = "param_error")]
        public List<ParamError> ParamError { get; set; }

        /// <summary>
        /// 服务器内部错误导致上传失败的点
        /// </summary>
        [DeserializeAs(Name = "internal_error")]
        public List<InternalError> InternalError { get; set; }
    }
}
