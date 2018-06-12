using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Space
{
    public class Entitie
    {
        /// <summary>
        /// entity名称，其唯一标识 
        /// </summary>
        [DeserializeAs(Name = "entity_name")]
        public string EntityName { get; set; }

        /// <summary>
        /// entity 可读性描述 
        /// </summary>
        [DeserializeAs(Name = "entity_desc")]
        public string EntityDesc { get; set; }

        /// <summary>
        /// entity属性修改时间
        /// </summary>
        [DeserializeAs(Name = "modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// entity创建时间
        /// </summary>
        [DeserializeAs(Name = "create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 开发者自定义字段
        /// </summary>
        [DeserializeAs(Name = "ext1")]
        public string Ext1 { get; set; }

        /// <summary>
        /// 开发者自定义字段
        /// </summary>
        [DeserializeAs(Name = "ext2")]
        public string Ext2 { get; set; }

        /// <summary>
        /// 开发者自定义字段
        /// </summary>
        [DeserializeAs(Name = "ext3")]
        public string Ext3 { get; set; }

        /// <summary>
        /// 最新的轨迹点信息
        /// </summary>
        [DeserializeAs(Name = "latest_location")]
        public LatestLocation LatestLocation { get; set; }
    }
}
