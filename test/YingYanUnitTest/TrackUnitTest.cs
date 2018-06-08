using Sino.Extensions.YingYan;
using Sino.Extensions.YingYan.Track;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace YingYanUnitTest
{
    public class TrackUnitTest : BaseTest
    {
        protected ITrackManager Manager { get; set; }
        public TrackUnitTest() : base()
        {
            Manager = new TrackManager(Client);
        }

        [Fact]
        public async Task AddPointTest()
        {
            var request = new AddPointRequest()
            {
                EntityName = "testCS",
                Latitude = 39.922018,
                Longitude = 116.44365,
                LocTime = 1488785466,
                CoordTypeInput = CoordType.BD09ll
            };
            var result = await Manager.AddPointAsync(request);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task AddPointsTest()
        {
            var list = new List<Point>();
            list.Add(new Point()
            {
                EntityName = "京Q8374W",
                LocTime = 1525232703,
                Latitude = 39.989715,
                Longitude = 116.437039,
                CoordTypeInput = CoordType.WGS84,
                Speed = 27.23,
                Direction = 178,
                Height = 173.3,
                Radius = 32,
                ObjectName = "12836"
            });
            var requset = new AddPointsRequest()
            {
                PointList = list
            };
            var result = await Manager.AddPointsAsync(requset);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetLatestPointTest()
        {
            var requset = new GetLatestPointRequest()
            {
                EntityName = "京Q8374W"
            };
            var result = await Manager.GetLatestPointAsync(requset);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetDistanceTest()
        {
            var requset = new GetDistanceRequest()
            {
                EntityName = "京Q8374W",
                StartTime = 1487203200,
                EndTime = 1487260800
            };
            var result = await Manager.GetDistanceAsync(requset);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetTrackTest()
        {
            var requset = new GetTrackRequest()
            {
                EntityName = "京Q8374W",
                StartTime = 1487203200,
                EndTime = 1487260800
            };
            var result = await Manager.GetTrackAsync(requset);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task StayPointTest()
        {
            var requset = new StayPointRequest()
            {
                EntityName = "京Q8374W",
                StartTime = 1487203200,
                EndTime = 1487260800
            };
            var result = await Manager.StayPointAsync(requset);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DrivingBehaviourTest()
        {
            var requset = new DrivingBehaviourRequest()
            {
                EntityName = "京Q8374W",
                StartTime = 1487203200,
                EndTime = 1487260800
            };
            var result = await Manager.DrivingBehaviourAsync(requset);
            Assert.NotNull(result);
        }
    }
}
