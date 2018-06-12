using Sino.Extensions.YingYan.Space;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace YingYanUnitTest
{
    public class SpaceUnitTest : BaseTest
    {
        protected ISpaceManager Manager { get; set; }
        public SpaceUnitTest() : base()
        {
            Manager = new SpaceManager(Client);
        }

        [Fact]
        public async Task SearchTest()
        {
            var request = new SearchRequest()
            {
                PageIndex = 1,
                PageSize = 100
            };
            var result = await Manager.SearchAsync(request);
            Assert.NotNull(result);
            Assert.Equal(0, result.Status);
        }

        [Fact]
        public async Task BoundSearchTest()
        {
            var request = new BoundSearchRequest()
            {
                Bounds = "36.20,116.30;37.20,117.30",
                PageIndex = 1,
                PageSize = 100
            };
            var result = await Manager.BoundSearchAsync(request);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task AroundSearchTest()
        {
            var request = new AroundSearchRequest()
            {
                Center = "36.20,116.30",
                Radius = 100,
                PageIndex = 1,
                PageSize = 100
            };
            var result = await Manager.AroundSearchAsync(request);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task PolygonSearchTest()
        {
            var request = new PolygonSearchRequest()
            {
                Vertexes = new string[] { "40.023759,116.20621", "40.027737,116.532762", "39.794407,116.570132", "39.79485,116.201036", "40.023759,116.20621" },
                PageIndex = 1,
                PageSize = 100
            };
            var result = await Manager.PolygonSearchAsync(request);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DistrictSearchTest()
        {
            var request = new DistrictSearchRequest()
            {
                KeyWord = "江苏镇江",
                PageIndex = 1,
                PageSize = 100
            };
            var result = await Manager.DistrictSearchAsync(request);
            Assert.NotNull(result);
        }
    }
}
