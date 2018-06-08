using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Conditions;
using RestSharp;
using Sino.Extensions.YingYan.Common.Extensions;
using Sino.Extensions.YingYan.Utils;

namespace Sino.Extensions.YingYan.Fence
{
    public class FenceManager : RootManager, IFenceManager
    {
        public FenceManager(HttpUtil http) : base(http)
        {
        }

        /// <summary>
        /// 增加围栏需监控的entity
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<AddMonitoredPersonReply> AddMonitoredPersonAsync(AddMonitoredPersonRequest requestValue)
        {
            if (requestValue.MonitoredPerson.Split(',').Length > 100)
            {

            }

            var request = new RestRequest("/fence/addmonitoredperson", Method.POST);
            request.AddParameter("fence_id", requestValue.FenceId, ParameterType.RequestBody);
            request.AddParameter("monitored_person", requestValue.MonitoredPerson, ParameterType.RequestBody);

            return await Client.PostAsync<AddMonitoredPersonReply>(request);
        }

        /// <summary>
        /// 批量查询某 service 下时间段以内的所有报警信息，用于服务端报警同步
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<BatchHistoryAlarmReply> BatchHistoryAlarmAsync(BatchHistoryAlarmRequest requestValue)
        {
            var request = new RestRequest("/fence/historyalarm", Method.GET);
            request.AddParameter("start_time", requestValue.StartTime, ParameterType.QueryString);
            request.AddParameter("end_time", requestValue.EndTime, ParameterType.QueryString);
            request.AddParameter("coord_type_output", requestValue.CoordTypeOutput.GetEnumDescription<CoordType>(), ParameterType.QueryString);
            request.AddParameter("page_index", requestValue.PageIndex, ParameterType.QueryString);
            request.AddParameter("page_size", requestValue.PageSize, ParameterType.QueryString);

            return await Client.PostAsync<BatchHistoryAlarmReply>(request);
        }

        /// <summary>
        /// 创建圆形围栏 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<CreateCircleFenceReply> CreateCircleFenceAsync(CreateCircleFenceRequest requestValue)
        {
            Condition.Requires(requestValue.Radius, nameof(requestValue.Radius))
            .IsInRange(0, 5000);

            var request = new RestRequest("/fence/createcirclefence", Method.POST);
            request.AddParameter("fence_name", requestValue.FenceName, ParameterType.RequestBody);
            request.AddParameter("monitored_person", requestValue.MonitoredPerson, ParameterType.RequestBody);
            request.AddParameter("longitude", requestValue.Longitude, ParameterType.RequestBody);
            request.AddParameter("latitude", requestValue.Latitude, ParameterType.RequestBody);
            request.AddParameter("coord_type", requestValue.CoordType.GetEnumDescription<CoordType>(), ParameterType.RequestBody);
            request.AddParameter("denoise", requestValue.Denoise, ParameterType.RequestBody);

            return await Client.PostAsync<CreateCircleFenceReply>(request);
        }

        /// <summary>
        /// 创建行政区划围栏
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<CreateDistrictFenceReply> CreateDistrictFenceAsync(CreateDistrictFenceRequest requestValue)
        {
            Condition.Requires(requestValue.KeyWord, nameof(requestValue.KeyWord))
            .IsNotEmpty();

            var request = new RestRequest("/fence/createdistrictfence", Method.POST);
            request.AddParameter("fence_name", requestValue.FenceName, ParameterType.RequestBody);
            request.AddParameter("monitored_person", requestValue.MonitoredPerson, ParameterType.RequestBody);
            request.AddParameter("keyword", requestValue.KeyWord, ParameterType.RequestBody);
            request.AddParameter("denoise", requestValue.Denoise, ParameterType.RequestBody);

            return await Client.PostAsync<CreateDistrictFenceReply>(request);
        }

        /// <summary>
        /// 创建多边形围栏
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<CreatePolygonFenceReply> CreatePolygonFenceAsync(CreatePolygonFenceRequest requestValue)
        {
            Condition.Requires(requestValue.Vertexes.Length, nameof(requestValue.Vertexes.Length))
            .IsInRange(3, 100);

            var request = new RestRequest("/fence/createpolygonfence", Method.POST);
            request.AddParameter("fence_name", requestValue.FenceName, ParameterType.RequestBody);
            request.AddParameter("monitored_person", requestValue.MonitoredPerson, ParameterType.RequestBody);
            request.AddParameter("vertexes", string.Join(";", requestValue.Vertexes), ParameterType.RequestBody);
            request.AddParameter("coord_type", requestValue.CoordType.GetEnumDescription<CoordType>(), ParameterType.RequestBody);
            request.AddParameter("denoise", requestValue.Denoise, ParameterType.RequestBody);

            return await Client.PostAsync<CreatePolygonFenceReply>(request);
        }

        /// <summary>
        /// 创建线型围栏
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<CreatePolylineFenceReply> CreatePolylineFenceAsync(CreatePolylineFenceRequest requestValue)
        {
            Condition.Requires(requestValue.Vertexes.Length, nameof(requestValue.Vertexes.Length))
            .IsInRange(2, 100);

            var request = new RestRequest("/fence/createpolylinefence", Method.POST);
            request.AddParameter("fence_name", requestValue.FenceName, ParameterType.RequestBody);
            request.AddParameter("monitored_person", requestValue.MonitoredPerson, ParameterType.RequestBody);
            request.AddParameter("vertexes", string.Join(";", requestValue.Vertexes), ParameterType.RequestBody);
            request.AddParameter("offset", requestValue.Offset, ParameterType.RequestBody);
            request.AddParameter("coord_type", requestValue.CoordType.GetEnumDescription<CoordType>(), ParameterType.RequestBody);
            request.AddParameter("denoise", requestValue.Denoise, ParameterType.RequestBody);

            return await Client.PostAsync<CreatePolylineFenceReply>(request);
        }

        /// <summary>
        /// 删除围栏
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<DeleteFenceReply> DeleteAsync(DeleteFenceRequest requestValue)
        {
            if (string.IsNullOrEmpty(requestValue.MonitoredPerson) && requestValue.FenceIds.Length == 0)
            {

            }

            var request = new RestRequest("/fence/delete", Method.POST);
            request.AddParameter("fence_name", requestValue.FenceName, ParameterType.RequestBody);
            request.AddParameter("monitored_person", requestValue.MonitoredPerson, ParameterType.RequestBody);
            request.AddParameter("fence_ids", requestValue.FenceIds, ParameterType.RequestBody);

            return await Client.PostAsync<DeleteFenceReply>(request);
        }

        /// <summary>
        /// 删除围栏可去除监控的entity
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<DeleteMonitoredPersonReply> DeleteMonitoredPersonAsync(DeleteMonitoredPersonRequest requestValue)
        {
            Condition.Requires(requestValue.MonitoredPerson.Split(',').Length, nameof(requestValue.MonitoredPerson))
            .IsInRange(0, 100);

            var request = new RestRequest("/fence/deletemonitoredperson ", Method.POST);
            request.AddParameter("fence_id", requestValue.FenceId, ParameterType.RequestBody);
            request.AddParameter("monitored_person", requestValue.MonitoredPerson, ParameterType.RequestBody);

            return await Client.PostAsync<DeleteMonitoredPersonReply>(request);
        }

        /// <summary>
        /// 查询某监控对象的历史报警信息 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<HistoryAlarmReply> HistoryAlarmAsync(HistoryAlarmRequest requestValue)
        {
            var request = new RestRequest("/fence/historyalarm", Method.GET);
            request.AddParameter("start_time", requestValue.StartTime, ParameterType.QueryString);
            request.AddParameter("end_time", requestValue.EndTime, ParameterType.QueryString);
            request.AddParameter("monitored_person", requestValue.MonitoredPerson, ParameterType.QueryString);
            request.AddParameter("fence_ids", requestValue.FenceIds, ParameterType.QueryString);
            request.AddParameter("coord_type_output", requestValue.CoordTypeOutput.GetEnumDescription<CoordType>(), ParameterType.QueryString);

            return await Client.PostAsync<HistoryAlarmReply>(request);
        }

        /// <summary>
        /// 查询围栏信息
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<ListFenceReply> ListAsync(ListRequest requestValue)
        {
            if (string.IsNullOrEmpty(requestValue.MonitoredPerson) && requestValue.FenceIds.Length == 0)
            {

            }

            var request = new RestRequest("/fence/list", Method.GET);
            request.AddParameter("fence_name", requestValue.FenceName, ParameterType.QueryString);
            request.AddParameter("monitored_person", requestValue.MonitoredPerson, ParameterType.QueryString);
            request.AddParameter("fence_ids", requestValue.FenceIds, ParameterType.QueryString);
            request.AddParameter("coord_type_output", requestValue.CoordTypeOutput.GetEnumDescription<CoordType>(), ParameterType.QueryString);

            return await Client.PostAsync<ListFenceReply>(request);
        }

        /// <summary>
        /// 查询围栏监控的所有entity
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<ListMonitoredPersonReply> ListMonitoredPersonAsync(ListMonitoredPersonRequest requestValue)
        {
            var request = new RestRequest("/fence/listmonitoredperson", Method.GET);
            request.AddParameter("fence_id", requestValue.FenceId, ParameterType.QueryString);
            request.AddParameter("page_index", requestValue.PageIndex, ParameterType.QueryString);
            request.AddParameter("page_size", requestValue.PageSize, ParameterType.QueryString);

            return await Client.PostAsync<ListMonitoredPersonReply>(request);
        }

        /// <summary>
        /// 查询监控对象在围栏内或外 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<QueryStatusReply> QueryStatusAsync(QueryStatusRequest requestValue)
        {
            var request = new RestRequest("/fence/querystatus", Method.GET);
            request.AddParameter("fence_ids", requestValue.FenceIds, ParameterType.QueryString);
            request.AddParameter("monitored_person", requestValue.MonitoredPerson, ParameterType.QueryString);

            return await Client.PostAsync<QueryStatusReply>(request);
        }

        /// <summary>
        /// 查询坐标在围栏内或外 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<QueryStatusByLocationReply> QueryStatusByLocationAsync(QueryStatusByLocationRequest requestValue)
        {
            var request = new RestRequest("/fence/querystatusbylocation", Method.GET);
            request.AddParameter("fence_ids", requestValue.FenceIds, ParameterType.QueryString);
            request.AddParameter("monitored_person", requestValue.MonitoredPerson, ParameterType.QueryString);
            request.AddParameter("longitude", requestValue.Longitude, ParameterType.QueryString);
            request.AddParameter("latidude", requestValue.Latitude, ParameterType.QueryString);
            request.AddParameter("coord_type", requestValue.CoordType.GetEnumDescription<CoordType>(), ParameterType.QueryString);

            return await Client.PostAsync<QueryStatusByLocationReply>(request);
        }

        /// <summary>
        /// 更新圆形围栏
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<UpdateCircleFenceReply> UpdateCircleFenceAsync(UpdateCircleFenceRequest requestValue)
        {
            Condition.Requires(requestValue.Radius, nameof(requestValue.Radius))
            .IsInRange(0, 5000);

            var request = new RestRequest("/fence/updatecirclefence", Method.POST);
            request.AddParameter("fence_id", requestValue.FenceId, ParameterType.RequestBody);
            request.AddParameter("fence_name", requestValue.FenceName, ParameterType.RequestBody);
            request.AddParameter("monitored_person", requestValue.MonitoredPerson, ParameterType.RequestBody);
            request.AddParameter("longitude", requestValue.Longitude, ParameterType.RequestBody);
            request.AddParameter("latitude", requestValue.Latitude, ParameterType.RequestBody);
            request.AddParameter("coord_type", requestValue.CoordType.GetEnumDescription<CoordType>(), ParameterType.RequestBody);
            request.AddParameter("denoise", requestValue.Denoise, ParameterType.RequestBody);

            return await Client.PostAsync<UpdateCircleFenceReply>(request);
        }

        /// <summary>
        /// 更新行政区划围栏
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<UpdateDistrictFenceReply> UpdateDistrictFenceAsync(UpdateDistrictFenceRequest requestValue)
        {
            var request = new RestRequest("/fence/updatedistrictfence", Method.POST);
            request.AddParameter("fence_id", requestValue.FenceId, ParameterType.RequestBody);
            request.AddParameter("fence_name", requestValue.FenceName, ParameterType.RequestBody);
            request.AddParameter("monitored_person", requestValue.MonitoredPerson, ParameterType.RequestBody);
            request.AddParameter("keyword", requestValue.KeyWord, ParameterType.RequestBody);
            request.AddParameter("denoise", requestValue.Denoise, ParameterType.RequestBody);

            return await Client.PostAsync<UpdateDistrictFenceReply>(request);
        }

        /// <summary>
        /// 更新多边形围栏 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<UpdatePolygonFenceReply> UpdatePolygonFenceAsync(UpdatePolygonFenceRequest requestValue)
        {
            Condition.Requires(requestValue.Vertexes.Length, nameof(requestValue.Vertexes))
             .IsInRange(3, 100);

            var request = new RestRequest("/fence/updatepolygonfence", Method.POST);
            request.AddParameter("fence_id", requestValue.FenceId, ParameterType.RequestBody);
            request.AddParameter("fence_name", requestValue.FenceName, ParameterType.RequestBody);
            request.AddParameter("monitored_person", requestValue.MonitoredPerson, ParameterType.RequestBody);
            request.AddParameter("vertexes", string.Join(";", requestValue.Vertexes), ParameterType.RequestBody);
            request.AddParameter("coord_type", requestValue.CoordType.GetEnumDescription<CoordType>(), ParameterType.RequestBody);
            request.AddParameter("denoise", requestValue.Denoise, ParameterType.RequestBody);

            return await Client.PostAsync<UpdatePolygonFenceReply>(request);
        }

        /// <summary>
        /// 更新线型围栏 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<UpdatePolylineFenceReply> UpdatePolylineFenceAsync(UpdatePolylineFenceRequest requestValue)
        {
            Condition.Requires(requestValue.Vertexes.Length, nameof(requestValue.Vertexes))
               .IsInRange(3, 100);

            var request = new RestRequest("/fence/updatepolylinefence", Method.POST);
            request.AddParameter("fence_id", requestValue.FenceId, ParameterType.RequestBody);
            request.AddParameter("fence_name", requestValue.FenceName, ParameterType.RequestBody);
            request.AddParameter("monitored_person", requestValue.MonitoredPerson, ParameterType.RequestBody);
            request.AddParameter("vertexes", string.Join(";", requestValue.Vertexes), ParameterType.RequestBody);
            request.AddParameter("offset", requestValue.Offset, ParameterType.RequestBody);
            request.AddParameter("coord_type", requestValue.CoordType.GetEnumDescription<CoordType>(), ParameterType.RequestBody);
            request.AddParameter("denoise", requestValue.Denoise, ParameterType.RequestBody);

            return await Client.PostAsync<UpdatePolylineFenceReply>(request);
        }
    }
}
