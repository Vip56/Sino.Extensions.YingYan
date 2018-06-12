using RestSharp.Deserializers;

namespace Sino.Extensions.YingYan
{
    /// <summary>
    /// 公共回应基类
    /// </summary>
    public abstract class Reply
    {
        /// <summary>
        /// 状态码
        /// </summary>
        [DeserializeAs(Name = "status")]
        public int Status { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        [DeserializeAs(Name = "message")]
        public string Message { get; set; }
    }
}
