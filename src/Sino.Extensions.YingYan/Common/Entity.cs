using RestSharp.Deserializers;

namespace Sino.Extensions.YingYan
{
    /// <summary>
    /// 实体对象
    /// </summary>
    public class Entity
    {
        /// <summary>
        /// 名称
        /// </summary>
        [DeserializeAs(Name = "entity_name")]
        public string Name { get; set; }

        /// <summary>
        /// 可读性描述
        /// </summary>
        [DeserializeAs(Name = "entity_desc")]
        public string Description { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [DeserializeAs(Name = "modify_time")]
        public string ModifyTimeStr { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [DeserializeAs(Name = "create_time")]
        public string CreateTimeStr { get; set; }

        /// <summary>
        /// 轨迹点信息
        /// </summary>
        [DeserializeAs(Name = "latest_location")]
        public Location LatestLocation { get; set; }
    }
}
