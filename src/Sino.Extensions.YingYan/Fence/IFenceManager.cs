using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sino.Extensions.YingYan.Fence
{
    public interface IFenceManager
    {
        /// <summary>
        /// 创建圆形围栏
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<CreateCircleFenceReply> CreateCircleFenceAsync(CreateCircleFenceRequest requestValue);

        /// <summary>
        /// 创建多边形围栏
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<CreatePolygonFenceReply> CreatePolygonFenceAsync(CreatePolygonFenceRequest requestValue);

        /// <summary>
        /// 创建线型围栏
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<CreatePolylineFenceReply> CreatePolylineFenceAsync(CreatePolylineFenceRequest requestValue);

        /// <summary>
        /// 创建行政区划围栏
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<CreateDistrictFenceReply> CreateDistrictFenceAsync(CreateDistrictFenceRequest requestValue);

        /// <summary>
        /// 更新圆形围栏
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<UpdateCircleFenceReply> UpdateCircleFenceAsync(UpdateCircleFenceRequest requestValue);

        /// <summary>
        /// 更新多边形围栏 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<UpdatePolygonFenceReply> UpdatePolygonFenceAsync(UpdatePolygonFenceRequest requestValue);

        /// <summary>
        /// 更新线型围栏 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<UpdatePolylineFenceReply> UpdatePolylineFenceAsync(UpdatePolylineFenceRequest requestValue);

        /// <summary>
        /// 更新行政区划围栏
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<UpdateDistrictFenceReply> UpdateDistrictFenceAsync(UpdateDistrictFenceRequest requestValue);

        /// <summary>
        /// 删除围栏
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<DeleteFenceReply> DeleteAsync(DeleteFenceRequest requestValue);

        /// <summary>
        /// 查询围栏信息
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<ListFenceReply> ListAsync(ListRequest requestValue);

        /// <summary>
        /// 增加围栏需监控的entity
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<AddMonitoredPersonReply> AddMonitoredPersonAsync(AddMonitoredPersonRequest requestValue);

        /// <summary>
        /// 删除围栏可去除监控的entity
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<DeleteMonitoredPersonReply> DeleteMonitoredPersonAsync(DeleteMonitoredPersonRequest requestValue);

        /// <summary>
        /// 查询围栏监控的所有entity
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<ListMonitoredPersonReply> ListMonitoredPersonAsync(ListMonitoredPersonRequest requestValue);

        /// <summary>
        /// 查询监控对象在围栏内或外 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<QueryStatusReply> QueryStatusAsync(QueryStatusRequest requestValue);

        /// <summary>
        /// 查询坐标在围栏内或外 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<QueryStatusByLocationReply> QueryStatusByLocationAsync(QueryStatusByLocationRequest requestValue);

        /// <summary>
        /// 查询某监控对象的历史报警信息 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<HistoryAlarmReply> HistoryAlarmAsync(HistoryAlarmRequest requestValue);

        /// <summary>
        /// 批量查询某 service 下时间段以内的所有报警信息，用于服务端报警同步
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<BatchHistoryAlarmReply> BatchHistoryAlarmAsync(BatchHistoryAlarmRequest requestValue);
    }
}
