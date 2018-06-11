using Sino.Extensions.YingYan.Export;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace YingYanUnitTest
{
    public class ExportUnitTest: BaseTest
    {
        protected IExportManager Manager { get; set; }
        public ExportUnitTest() : base()
        {
            Manager = new ExportManager(Client);
        }

        [Fact]
        public async Task CreateJobTest()
        {
            var requset = new CreateJobRequest()
            {
                StartTime = 1487203200,
                EndTime = 1487260800
            };
            var result = await Manager.CreateJobAsync(requset);
            Assert.NotNull(result);
            Assert.Equal(0, result.Status);
        }

        [Fact]
        public async Task DeleteJobTest()
        {
            var requset = new DeleteJobRequest()
            {
                 JobId= 138318
            };
            var result = await Manager.DeleteJobAsync(requset);
            Assert.NotNull(result);
            Assert.Equal(0, result.Status);
        }

        [Fact]
        public async Task GetJobTest()
        {
            var result = await Manager.GetJobAsync();
            Assert.NotNull(result);
            Assert.Equal(0, result.Status);
        }
    }
}
