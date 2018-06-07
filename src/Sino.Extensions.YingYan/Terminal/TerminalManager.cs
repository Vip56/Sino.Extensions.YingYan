using RestSharp;
using Sino.Extensions.YingYan.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sino.Extensions.YingYan.Terminal
{
    public class TerminalManager : RootManager, ITerminalManager
    {
        public TerminalManager(HttpUtil http)
            : base(http) { }

        public async Task<AddTerminalReply> AddAsync(AddTerminalRequest requestValue)
        {


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
