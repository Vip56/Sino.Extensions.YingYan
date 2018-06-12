using Conditions;
using Sino.Extensions.YingYan.Export;
using Sino.Extensions.YingYan.Fence;
using Sino.Extensions.YingYan.Space;
using Sino.Extensions.YingYan.Terminal;
using Sino.Extensions.YingYan.Track;
using Sino.Extensions.YingYan.Utils;

namespace Sino.Extensions.YingYan
{
    public class YingYanService : IYingYanService
    {
        private HttpUtil _http;
        private IExportManager _export;
        private IFenceManager _fence;
        private ISpaceManager _space;
        private ITerminalManager _terminal;
        private ITrackManager _track;

        public YingYanService(string url, string ak, string serviceId)
        {
            Condition.Requires(url, nameof(url))
                .IsNotNull()
                .IsNotEmpty();

            Condition.Requires(ak, nameof(ak))
                .IsNotNull()
                .IsNotEmpty();

            Condition.Requires(serviceId, nameof(serviceId))
                .IsNotNull()
                .IsNotEmpty();

            _http = new HttpUtil(url, ak, serviceId);
        }

        public IExportManager GetExportManager()
        {
            if(_export == null)
            {
                _export = new ExportManager(_http);
            }
            return _export;
        }

        public IFenceManager GetFenceManager()
        {
            if (_fence == null)
            {
                _fence = new FenceManager(_http);
            }
            return _fence;
        }

        public ISpaceManager GetSpaceManager()
        {
            if(_space == null)
            {
                _space = new SpaceManager(_http);
            }
            return _space;
        }

        public ITerminalManager GetTerminalManager()
        {
            if(_terminal == null)
            {
                _terminal = new TerminalManager(_http);
            }
            return _terminal;
        }

        public ITrackManager GetTrackManager()
        {
            if(_track == null)
            {
                _track = new TrackManager(_http);
            }
            return _track;
        }
    }
}
