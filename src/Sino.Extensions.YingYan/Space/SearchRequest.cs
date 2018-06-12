using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.YingYan.Space
{
    public class SearchRequest: SpaceRequest
    {
        /// <summary>
        /// 搜索关键字
        /// </summary>
        public string Query { get; set; }
    }
}
