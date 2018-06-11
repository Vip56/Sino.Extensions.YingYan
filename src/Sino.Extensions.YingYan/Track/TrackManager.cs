using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Conditions;
using RestSharp;
using Sino.Extensions.YingYan.Common.Extensions;
using Sino.Extensions.YingYan.Utils;
using Newtonsoft.Json;


namespace Sino.Extensions.YingYan.Track
{
    public class TrackManager : RootManager, ITrackManager
    {
        public TrackManager(HttpUtil http) : base(http)
        {
        }

        /// <summary>
        /// 上传单个轨迹点
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<AddPointReply> AddPointAsync(AddPointRequest requestValue)
        {
            Condition.Requires(requestValue.EntityName, nameof(requestValue.EntityName))
            .IsShorterOrEqual(128);
            Condition.Requires(requestValue.Latitude, nameof(requestValue.Latitude))
            .IsInRange(-90.0, 90.0);
            Condition.Requires(requestValue.Longitude, nameof(requestValue.Longitude))
            .IsInRange(-180.0, 180.0);

            var request = new RestRequest("/track/addpoint", Method.POST);
            request.AddParameter("entity_name", requestValue.EntityName);
            request.AddParameter("latitude", requestValue.Latitude);
            request.AddParameter("longitude", requestValue.Longitude);
            request.AddParameter("loc_time", requestValue.LocTime);
            request.AddParameter("coord_type_input", requestValue.CoordTypeInput.GetEnumDescription<CoordType>());
            request.AddParameter("speed", requestValue.Speed);
            request.AddParameter("direction", requestValue.Direction);
            request.AddParameter("height", requestValue.Height);
            request.AddParameter("radius", requestValue.Radius);
            request.AddParameter("object_name", requestValue.ObjectName);

            return await Client.PostAsync<AddPointReply>(request);
        }

        /// <summary>
        /// 批量上传多个 entity 的多个轨迹点。与 v2版接口不同的是：1. 轨迹点列表采用 json格式，而非.csv 文件；2.一次请求可上传多个 entity 的轨迹点； 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<AddPointsReply> AddPointsAsync(AddPointsRequest requestValue)
        {
            Condition.Requires(requestValue.PointList, nameof(requestValue.PointList))
            .IsNotNull();
            var request = new RestRequest("/track/addpoints", Method.POST);
            request.AddParameter("point_list", JsonConvert.SerializeObject(requestValue.PointList));

            return await Client.PostAsync<AddPointsReply>(request);
        }

        /// <summary>
        /// 驾驶行为分析
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<DrivingBehaviourReply> DrivingBehaviourAsync(DrivingBehaviourRequest requestValue)
        {
            Condition.Requires(requestValue.EntityName, nameof(requestValue.EntityName))
            .IsNotNullOrEmpty();

            var request = new RestRequest("/analysis/drivingbehavior", Method.GET);
            request.AddParameter("entity_name", requestValue.EntityName, ParameterType.QueryString);
            request.AddParameter("start_time", requestValue.StartTime, ParameterType.QueryString);
            request.AddParameter("end_time", requestValue.EndTime, ParameterType.QueryString);
            request.AddParameter("speeding_threshold", requestValue.SpeedingThreshold, ParameterType.QueryString);
            request.AddParameter("harsh_acceleration_threshold", requestValue.HarshAccelerationThreshold, ParameterType.QueryString);
            request.AddParameter("harsh_breaking_threshold", requestValue.HarshBreakingThreshold, ParameterType.QueryString);
            request.AddParameter("harsh_steering_threshold", requestValue.HarshSteeringThreshold, ParameterType.QueryString);
            request.AddParameter("process_option", requestValue.ProcessOption, ParameterType.QueryString);
            request.AddParameter("coord_type_output", requestValue.CoordTypeOutput.GetEnumDescription<CoordType>(), ParameterType.QueryString);

            return await Client.GetAsync<DrivingBehaviourReply>(request);
        }

        /// <summary>
        /// 查询某 entity 一段时间内的轨迹里程，支持纠偏 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<GetDistanceReply> GetDistanceAsync(GetDistanceRequest requestValue)
        {
            Condition.Requires(requestValue.EntityName, nameof(requestValue.EntityName))
            .IsNotNullOrEmpty();

            var request = new RestRequest("/track/getdistance", Method.GET);
            request.AddParameter("entity_name", requestValue.EntityName, ParameterType.QueryString);
            request.AddParameter("start_time", requestValue.StartTime, ParameterType.QueryString);
            request.AddParameter("end_time", requestValue.EndTime, ParameterType.QueryString);
            request.AddParameter("is_processed", requestValue.IsProcessed, ParameterType.QueryString);
            request.AddParameter("process_option", requestValue.ProcessOption, ParameterType.QueryString);
            request.AddParameter("supplement_mode", requestValue.SupplementMode, ParameterType.QueryString);

            return await Client.GetAsync<GetDistanceReply>(request);
        }

        /// <summary>
        /// 查询某 entity 的实时位置，支持纠偏 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<GetLatestPointReply> GetLatestPointAsync(GetLatestPointRequest requestValue)
        {
            Condition.Requires(requestValue.EntityName, nameof(requestValue.EntityName))
             .IsNotNullOrEmpty();

            var request = new RestRequest("/track/getlatestpoint", Method.GET);
            request.AddParameter("entity_name", requestValue.EntityName, ParameterType.QueryString);
            request.AddParameter("process_option", requestValue.ProcessOption, ParameterType.QueryString);
            request.AddParameter("coord_type_output", requestValue.CoordTypeOutput.GetEnumDescription<CoordType>(), ParameterType.QueryString);

            return await Client.GetAsync<GetLatestPointReply>(request);
        }

        /// <summary>
        /// 查询某 entity 一段时间内的轨迹点，支持纠偏 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<GetTrackReply> GetTrackAsync(GetTrackRequest requestValue)
        {
            Condition.Requires(requestValue.EntityName, nameof(requestValue.EntityName))
            .IsNotNullOrEmpty();

            var request = new RestRequest("/track/gettrack", Method.GET);
            request.AddParameter("entity_name", requestValue.EntityName, ParameterType.QueryString);
            request.AddParameter("start_time", requestValue.StartTime, ParameterType.QueryString);
            request.AddParameter("end_time", requestValue.EndTime, ParameterType.QueryString);
            request.AddParameter("is_processed", requestValue.IsProcessed, ParameterType.QueryString);
            request.AddParameter("process_option", requestValue.ProcessOption, ParameterType.QueryString);
            request.AddParameter("supplement_mode", requestValue.SupplementMode, ParameterType.QueryString);
            request.AddParameter("coord_type_output", requestValue.CoordTypeOutput.GetEnumDescription<CoordType>(), ParameterType.QueryString);
            request.AddParameter("sort_type", requestValue.SortType, ParameterType.QueryString);
            request.AddParameter("page_index", requestValue.PageIndex, ParameterType.QueryString);
            request.AddParameter("page_size", requestValue.PageSize, ParameterType.QueryString);

            return await Client.GetAsync<GetTrackReply>(request);
        }

        /// <summary>
        /// 停留点分析
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        public async Task<StayPointReply> StayPointAsync(StayPointRequest requestValue)
        {
            Condition.Requires(requestValue.EntityName, nameof(requestValue.EntityName))
            .IsNotNullOrEmpty()
            .IsShorterOrEqual(128);

            var request = new RestRequest("/analysis/staypoint", Method.GET);
            request.AddParameter("entity_name", requestValue.EntityName, ParameterType.QueryString);
            request.AddParameter("start_time", requestValue.StartTime, ParameterType.QueryString);
            request.AddParameter("end_time", requestValue.EndTime, ParameterType.QueryString);
            request.AddParameter("stay_time", requestValue.StayTime, ParameterType.QueryString);
            request.AddParameter("stay_radius", requestValue.StayRadius, ParameterType.QueryString);
            request.AddParameter("process_option", requestValue.ProcessOption, ParameterType.QueryString);
            request.AddParameter("coord_type_output", requestValue.CoordTypeOutput.GetEnumDescription<CoordType>(), ParameterType.QueryString);

            return await Client.GetAsync<StayPointReply>(request);
        }
    }
}
