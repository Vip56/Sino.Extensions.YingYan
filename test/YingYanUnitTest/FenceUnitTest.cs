using Sino.Extensions.YingYan;
using Sino.Extensions.YingYan.Fence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace YingYanUnitTest
{
    public class FenceUnitTest : BaseTest
    {
        protected IFenceManager Manager { get; set; }
        public FenceUnitTest() : base()
        {
            Manager = new FenceManager(Client);
        }

        [Fact]
        public async Task CreateCircleFenceTest()
        {
            var request = new CreateCircleFenceRequest()
            {
                Latitude = 90,
                Longitude = 32,
                Radius = 500,
                CoordType = CoordType.BD09ll
            };
            var result = await Manager.CreateCircleFenceAsync(request);
            Assert.NotNull(result);
            Assert.Equal(0, result.Status);
        }

        [Fact]
        public async Task CreatePolygonFenceTest()
        {
            var request = new CreatePolygonFenceRequest()
            {
                Vertexes = new string[] { "39.746539,116.236253", "39.746739,116.236", "39.746222,116.234" },
                CoordType = CoordType.BD09ll
            };
            var result = await Manager.CreatePolygonFenceAsync(request);
            Assert.NotNull(result);
            Assert.Equal(0, result.Status);
        }

        [Fact]
        public async Task CreatePolylineFenceTest()
        {
            var requset = new CreatePolylineFenceRequest()
            {
                Vertexes = new string[] { "39.746539,116.236253", "39.746739,116.236", "39.746222,116.234" },
                Offset = 200,
                CoordType = CoordType.BD09ll
            };
            var result = await Manager.CreatePolylineFenceAsync(requset);
            Assert.NotNull(result);
            Assert.Equal(0, result.Status);
        }

        [Fact]
        public async Task CreateDistrictFenceTest()
        {
            var requset = new CreateDistrictFenceRequest()
            {
                KeyWord = "江苏省镇江市"
            };
            var result = await Manager.CreateDistrictFenceAsync(requset);
            Assert.NotNull(result);
            Assert.Equal(0, result.Status);
        }

        [Fact]
        public async Task UpdateCircleFenceTest()
        {
            var requset = new UpdateCircleFenceRequest()
            {
                FenceId = 1,
                CoordType = CoordType.BD09ll,
                Radius = 1.1
            };
            var result = await Manager.UpdateCircleFenceAsync(requset);
            Assert.NotNull(result);
            Assert.Equal(0, result.Status);
        }

        [Fact]
        public async Task UpdatePolygonFenceTest()
        {
            var requset = new UpdatePolygonFenceRequest()
            {
                FenceId = 8,
                CoordType = CoordType.BD09ll
            };
            var result = await Manager.UpdatePolygonFenceAsync(requset);
            Assert.NotNull(result);
            Assert.Equal(0, result.Status);
        }

        [Fact]
        public async Task UpdatePolylineFenceTest()
        {
            var requset = new UpdatePolylineFenceRequest()
            {
                FenceId = 9,
                CoordType = CoordType.BD09ll
            };
            var result = await Manager.UpdatePolylineFenceAsync(requset);
            Assert.NotNull(result);
            Assert.Equal(0, result.Status);
        }

        [Fact]
        public async Task UpdateDistrictFenceTest()
        {
            var requset = new UpdateDistrictFenceRequest()
            {
                FenceId = 10,
                KeyWord = "江苏南京"
            };
            var result = await Manager.UpdateDistrictFenceAsync(requset);
            Assert.NotNull(result);
            Assert.Equal(0, result.Status);
        }

        [Fact]
        public async Task DeleteTest()
        {
            var requset = new DeleteFenceRequest()
            {
                FenceIds = " 1, 2"
            };
            var result = await Manager.DeleteAsync(requset);
            Assert.NotNull(result);
            Assert.Equal(0, result.Status);
        }

        [Fact]
        public async Task ListTest()
        {
            var requset = new ListRequest()
            {
                FenceIds = "259, 260"
            };
            var result = await Manager.ListAsync(requset);
            Assert.NotNull(result);
            Assert.Equal(0, result.Status);
        }

        [Fact]
        public async Task AddMonitoredPersonTest()
        {
            var requset = new AddMonitoredPersonRequest()
            {
                FenceId = 3,
                MonitoredPerson = "小明"
            };
            var result = await Manager.AddMonitoredPersonAsync(requset);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DeleteMonitoredPersonTest()
        {
            var requset = new DeleteMonitoredPersonRequest()
            {
                FenceId = 3,
                MonitoredPerson = "小明"
            };
            var result = await Manager.DeleteMonitoredPersonAsync(requset);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task ListMonitoredPersonTest()
        {
            var requset = new ListMonitoredPersonRequest()
            {
                FenceId = 1,
                PageIndex = 1,
                PageSize = 100
            };
            var result = await Manager.ListMonitoredPersonAsync(requset);
            Assert.NotNull(result);
            Assert.Equal(0, result.Status);
        }

        [Fact]
        public async Task QueryStatusTest()
        {
            var requset = new QueryStatusRequest()
            {
                MonitoredPerson = "小明"
            };
            var result = await Manager.QueryStatusAsync(requset);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task QueryStatusByLocationTest()
        {
            var requset = new QueryStatusByLocationRequest()
            {
                MonitoredPerson = "小明",
                Longitude = 116.334129,
                Latitude = 40.010939,
                CoordType = CoordType.BD09ll
            };
            var result = await Manager.QueryStatusByLocationAsync(requset);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task HistoryAlarmTest()
        {
            var requset = new HistoryAlarmRequest()
            {
                MonitoredPerson = "小明"
            };
            var result = await Manager.HistoryAlarmAsync(requset);
            Assert.NotNull(result);
            Assert.Equal(0, result.Status);
        }

        [Fact]
        public async Task BatchHistoryAlarmTest()
        {
            var requset = new BatchHistoryAlarmRequest()
            {
                StartTime = 1528704032,
                EndTime = 1528705032
            };
            var result = await Manager.BatchHistoryAlarmAsync(requset);
            Assert.NotNull(result);
            Assert.Equal(0, result.Status);
        }
    }
}
