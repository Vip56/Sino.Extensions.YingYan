using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sino.Extensions.YingYan.Space
{
    public  interface ISpaceManager
    {
        /// <summary>
        /// 根据关键字搜索entity 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<SearchReply> SearchAsync(SearchRequest requestValue);

        /// <summary>
        /// 根据矩形范围搜索entity 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<BoundSearchReply> BoundSearchAsync(BoundSearchRequest requestValue);

        /// <summary>
        /// 周边搜索，根据圆心和半径搜索 entity 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<AroundSearchReply> AroundSearchAsync(AroundSearchRequest requestValue);

        /// <summary>
        /// 多边形搜索，搜索多边形范围内的entity 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<PolygonSearchReply> PolygonSearchAsync(PolygonSearchRequest requestValue);

        /// <summary>
        /// 行政区搜索，搜索行政区范围内的entity 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<DistrictSearchReply> DistrictSearchAsync(DistrictSearchRequest requestValue);
    }
}
