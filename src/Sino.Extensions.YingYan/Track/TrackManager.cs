using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sino.Extensions.YingYan.Utils;

namespace Sino.Extensions.YingYan.Track
{
    public class TrackManager : RootManager, ITrackManager
    {
        public TrackManager(HttpUtil http) : base(http)
        {
        }

        public Task<AddPointReply> AddPointAsync(AddPointRequest requestValue)
        {
            throw new NotImplementedException();
        }

        public Task<AddPointsReply> AddPointsAsync(AddPointsRequest requestValue)
        {
            throw new NotImplementedException();
        }

        public Task<DrivingBehaviourReply> DrivingBehaviourAsync(DrivingBehaviourRequest requestValue)
        {
            throw new NotImplementedException();
        }

        public Task<GetDistanceReply> GetDistanceAsync(GetDistanceRequest requestValue)
        {
            throw new NotImplementedException();
        }

        public Task<GetLatestPointReply> GetLatestPointAsync(GetLatestPointRequest requestValue)
        {
            throw new NotImplementedException();
        }

        public Task<GetTrackReply> GetTrackAsync(GetTrackRequest requestValue)
        {
            throw new NotImplementedException();
        }

        public Task<StayPointReply> StayPointAsync(StayPointRequest requestValue)
        {
            throw new NotImplementedException();
        }
    }
}
