using Sino.Extensions.YingYan.Export;
using Sino.Extensions.YingYan.Fence;
using Sino.Extensions.YingYan.Space;
using Sino.Extensions.YingYan.Terminal;
using Sino.Extensions.YingYan.Track;

namespace Sino.Extensions.YingYan
{
    /// <summary>
    /// 鹰眼服务接口
    /// </summary>
    public interface IYingYanService
    {
        /// <summary>
        /// 获取导出管理
        /// </summary>
        IExportManager GetExportManager();

        /// <summary>
        /// 获取围栏管理
        /// </summary>
        IFenceManager GetFenceManager();

        /// <summary>
        /// 获取周边管理
        /// </summary>
        ISpaceManager GetSpaceManager();

        /// <summary>
        /// 获取终端管理
        /// </summary>
        ITerminalManager GetTerminalManager();

        /// <summary>
        /// 获取轨迹管理
        /// </summary>
        ITrackManager GetTrackManager();
    }
}
