using System.Threading.Tasks;

namespace Sino.Extensions.YingYan.Terminal
{
    /// <summary>
    /// 终端管理接口
    /// </summary>
    public interface ITerminalManager
    {
        /// <summary>
        /// 添加终端
        /// </summary>
        Task<AddTerminalReply> AddAsync(AddTerminalRequest requestValue);

        /// <summary>
        /// 更新终端
        /// </summary>
        Task<UpdateTerminalReply> UpdateAsync(UpdateTerminalRequest requestValue);

        /// <summary>
        /// 删除终端
        /// </summary>
        Task<DeleteTerminalReply> DeleteAsync(DeleteTerminalRequest requestValue);

        /// <summary>
        /// 检索终端
        /// </summary>
        Task<ListTerminalReply> ListAsync(ListTerminalRequest requestValue);
    }
}
