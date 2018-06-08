using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sino.Extensions.YingYan.Export
{
    public  interface IExportManager
    {

        Task<CreateJobReply> CreateJobAsync(CreateJobRequest requestValue);

        Task<DeleteJobReply> DeleteJobAsync(DeleteJobRequest requestValue);

        Task<GetJobReply> GetJobAsync(GetJobRequest requestValue);
    }
}
