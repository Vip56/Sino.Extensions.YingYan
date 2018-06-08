using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sino.Extensions.YingYan.Utils;

namespace Sino.Extensions.YingYan.Space
{
    public class SpaceManager : RootManager, ISpaceManager
    {
        public SpaceManager(HttpUtil http) : base(http)
        {
        }

        public Task<AroundSearchReply> AroundSearchAsync(AroundSearchRequest requestValue)
        {
            throw new NotImplementedException();
        }

        public Task<BoundSearchReply> BoundSearchAsync(BoundSearchRequest requestValue)
        {
            throw new NotImplementedException();
        }

        public Task<DistrictSearchReply> DistrictSearchAsync(DistrictSearchRequest requestValue)
        {
            throw new NotImplementedException();
        }

        public Task<PolygonSearchReply> PolygonSearchAsync(PolygonSearchRequest requestValue)
        {
            throw new NotImplementedException();
        }

        public Task<SearchReply> SearchAsync(SearchRequest requestValue)
        {
            throw new NotImplementedException();
        }
    }
}
