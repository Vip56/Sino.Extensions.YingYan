using RestSharp;
using Sino.Extensions.YingYan.Utils;
using System;
using Conditions;
using System.Threading.Tasks;

namespace Sino.Extensions.YingYan.Terminal
{
    public class TerminalManager : RootManager, ITerminalManager
    {
        public TerminalManager(HttpUtil http)
            : base(http) { }

        public async Task<AddTerminalReply> AddAsync(AddTerminalRequest requestValue)
        {
            Condition.Requires(requestValue.Name, nameof(requestValue.Name))
                .IsNotNull()
                .IsNotEmpty()
                .IsShorterOrEqual(128)
                .IsWordOrNumberOrLine();

            Condition.Requires(requestValue.Description, nameof(requestValue.Description))
                .IsShorterOrEqual(128)
                .IsWordOrNumberOrLine();

            var request = new RestRequest("/entity/add", Method.POST);
            request.AddParameter("entity_name", requestValue.Name);
            request.AddParameter("entity_desc", requestValue.Description);
            if(requestValue.Ext != null && requestValue.Ext.Count > 0)
            {
                foreach(var item in requestValue.Ext)
                {
                    request.AddParameter(item.Key, item.Value, ParameterType.RequestBody);
                }
            }

            return await Client.PostAsync<AddTerminalReply>(request);
        }

        public Task<DeleteTerminalReply> DeleteAsync(DeleteTerminalRequest requestValue)
        {
            throw new NotImplementedException();
        }

        public Task<ListTerminalReply> ListAsync(ListTerminalRequest requestValue)
        {
            throw new NotImplementedException();
        }

        public Task<UpdateTerminalReply> UpdateAsync(UpdateTerminalRequest requestValue)
        {
            throw new NotImplementedException();
        }
    }
}
