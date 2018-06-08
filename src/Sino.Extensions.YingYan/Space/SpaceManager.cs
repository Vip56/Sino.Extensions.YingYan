using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Sino.Extensions.YingYan.Common.Extensions;
using Sino.Extensions.YingYan.Utils;

namespace Sino.Extensions.YingYan.Space
{
    public class SpaceManager : RootManager, ISpaceManager
    {
        public SpaceManager(HttpUtil http) : base(http)
        {
        }

        /// <summary>
        /// 周边搜索，根据圆心和半径搜索 entity 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<AroundSearchReply> AroundSearchAsync(AroundSearchRequest requestValue)
        {
            var request = new RestRequest("/entity/aroundsearch ", Method.GET);
            request.AddParameter("center", requestValue.Center, ParameterType.QueryString);
            request.AddParameter("radius", requestValue.Radius, ParameterType.QueryString);
            request.AddParameter("filter", requestValue.Filter, ParameterType.QueryString);
            request.AddParameter("sortby", requestValue.Sortby, ParameterType.QueryString);
            request.AddParameter("coord_type_input", requestValue.CoordTypeOutput.GetEnumDescription<CoordType>(), ParameterType.QueryString);
            request.AddParameter("coord_type_output", requestValue.CoordTypeOutput.GetEnumDescription<CoordType>(), ParameterType.QueryString);
            request.AddParameter("page_index", requestValue.PageIndex, ParameterType.QueryString);
            request.AddParameter("page_size", requestValue.PageSize, ParameterType.QueryString);

            return await Client.PostAsync<AroundSearchReply>(request);
        }

        /// <summary>
        /// 根据矩形范围搜索entity 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<BoundSearchReply> BoundSearchAsync(BoundSearchRequest requestValue)
        {
            var request = new RestRequest("/entity/boundsearch ", Method.GET);
            request.AddParameter("bounds", requestValue.Bounds, ParameterType.QueryString);
            request.AddParameter("filter", requestValue.Filter, ParameterType.QueryString);
            request.AddParameter("sortby", requestValue.Sortby, ParameterType.QueryString);
            request.AddParameter("coord_type_input", requestValue.CoordTypeOutput.GetEnumDescription<CoordType>(), ParameterType.QueryString);
            request.AddParameter("coord_type_output", requestValue.CoordTypeOutput.GetEnumDescription<CoordType>(), ParameterType.QueryString);
            request.AddParameter("page_index", requestValue.PageIndex, ParameterType.QueryString);
            request.AddParameter("page_size", requestValue.PageSize, ParameterType.QueryString);

            return await Client.PostAsync<BoundSearchReply>(request);
        }

        /// <summary>
        /// 行政区搜索，搜索行政区范围内的entity 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<DistrictSearchReply> DistrictSearchAsync(DistrictSearchRequest requestValue)
        {
            var request = new RestRequest("/entity/boundsearch ", Method.GET);
            request.AddParameter("keyword", requestValue.KeyWord, ParameterType.QueryString);
            request.AddParameter("filter", requestValue.Filter, ParameterType.QueryString);
            request.AddParameter("sortby", requestValue.Sortby, ParameterType.QueryString);
            request.AddParameter("return_type", requestValue.ReturnType, ParameterType.QueryString);
            request.AddParameter("coord_type_output", requestValue.CoordTypeOutput.GetEnumDescription<CoordType>(), ParameterType.QueryString);
            request.AddParameter("page_index", requestValue.PageIndex, ParameterType.QueryString);
            request.AddParameter("page_size", requestValue.PageSize, ParameterType.QueryString);

            return await Client.PostAsync<DistrictSearchReply>(request);
        }

        /// <summary>
        /// 多边形搜索，搜索多边形范围内的entity 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<PolygonSearchReply> PolygonSearchAsync(PolygonSearchRequest requestValue)
        {
            var request = new RestRequest("/entity/polygonsearch ", Method.GET);
            request.AddParameter("vertexes", string.Join(";", requestValue.Vertexes), ParameterType.QueryString);
            request.AddParameter("filter", requestValue.Filter, ParameterType.QueryString);
            request.AddParameter("sortby", requestValue.Sortby, ParameterType.QueryString);
            request.AddParameter("coord_type_input", requestValue.CoordTypeOutput.GetEnumDescription<CoordType>(), ParameterType.QueryString);
            request.AddParameter("coord_type_output", requestValue.CoordTypeOutput.GetEnumDescription<CoordType>(), ParameterType.QueryString);
            request.AddParameter("page_index", requestValue.PageIndex, ParameterType.QueryString);
            request.AddParameter("page_size", requestValue.PageSize, ParameterType.QueryString);

            return await Client.PostAsync<PolygonSearchReply>(request);
        }

        /// <summary>
        /// 根据关键字搜索entity 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<SearchReply> SearchAsync(SearchRequest requestValue)
        {
            var request = new RestRequest("/entity/search", Method.GET);
            request.AddParameter("query", requestValue.Query, ParameterType.QueryString);
            request.AddParameter("filter", requestValue.Filter, ParameterType.QueryString);
            request.AddParameter("sortby", requestValue.Sortby, ParameterType.QueryString);
            request.AddParameter("coord_type_output", requestValue.CoordTypeOutput.GetEnumDescription<CoordType>(), ParameterType.QueryString);
            request.AddParameter("page_index", requestValue.PageIndex, ParameterType.QueryString);
            request.AddParameter("page_size", requestValue.PageSize, ParameterType.QueryString);

            return await Client.PostAsync<SearchReply>(request);
        }
    }
}
