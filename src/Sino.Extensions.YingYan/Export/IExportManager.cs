using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sino.Extensions.YingYan.Export
{
    public interface IExportManager
    {

        /// <summary>
        /// 创建一个任务，该任务完成后将返回文件下载地址，供开发者下载 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<CreateJobReply> CreateJobAsync(CreateJobRequest requestValue);

        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<DeleteJobReply> DeleteJobAsync(DeleteJobRequest requestValue);

        /// <summary>
        /// 查询任务，将返回任务状态和文件下载地址 
        /// </summary>
        /// <param name="requestValue"></param>
        /// <returns></returns>
        Task<GetJobReply> GetJobAsync();
    }
}
