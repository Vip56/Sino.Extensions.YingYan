using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sino.Extensions.YingYan.Track
{
    /// <summary>
    /// 轨迹
    /// </summary>
    public interface ITrackManager
    {
        /// <summary>
        /// 上传单个轨迹点
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<AddPointReply> AddPointAsync(AddPointRequest requestValue);

        /// <summary>
        /// 批量上传多个 entity 的多个轨迹点。与 v2版接口不同的是：1. 轨迹点列表采用 json格式，而非.csv 文件；2.一次请求可上传多个 entity 的轨迹点； 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<AddPointsReply> AddPointsAsync(AddPointsRequest requestValue);

        /// <summary>
        /// 查询某 entity 的实时位置，支持纠偏 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<GetLatestPointReply> GetLatestPointAsync(GetLatestPointRequest requestValue);

        /// <summary>
        /// 查询某 entity 一段时间内的轨迹里程，支持纠偏 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<GetDistanceReply> GetDistanceAsync(GetDistanceRequest requestValue);

        /// <summary>
        /// 查询某 entity 一段时间内的轨迹点，支持纠偏 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<GetTrackReply> GetTrackAsync(GetTrackRequest requestValue);

        /// <summary>
        /// 停留点分析
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<StayPointReply> StayPointAsync(StayPointRequest requestValue);

        /// <summary>
        /// 驾驶行为分析
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<DrivingBehaviourReply> DrivingBehaviourAsync(DrivingBehaviourRequest requestValue);
    }
}
