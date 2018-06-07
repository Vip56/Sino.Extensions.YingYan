using RestSharp;
using Sino.Extensions.YingYan.Utils;
using System;
using Conditions;
using System.Threading.Tasks;
using System.Text;
using Sino.Extensions.YingYan.Common.Extensions;

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

        public async Task<DeleteTerminalReply> DeleteAsync(DeleteTerminalRequest requestValue)
        {
            Condition.Requires(requestValue.Name, nameof(requestValue.Name))
                .IsNotNull()
                .IsNotEmpty();

            var request = new RestRequest("entity/delete", Method.POST);
            request.AddParameter("entity_name", requestValue.Name);

            return await Client.PostAsync<DeleteTerminalReply>(request);
        }

        public async Task<ListTerminalReply> ListAsync(ListTerminalRequest requestValue)
        {
            if(requestValue.ActiveTime != null && requestValue.InactiveTime != null)
            {
                throw new ArgumentException("activeTime and inactiveTime can not use together", nameof(requestValue.ActiveTime));
            }

            var request = new RestRequest("entity/list", Method.GET);
            StringBuilder filter = new StringBuilder();
            if(requestValue.Names != null && requestValue.Names.Count > 0)
            {
                filter.Append("entity_names:");
                filter.Append(string.Join(",", requestValue.Names));
            }

            if(requestValue.ActiveTime != null)
            {
                filter.Append("|");
                filter.Append("active_time:");
                filter.Append(requestValue.ActiveTime.AddHours(-8).ToUnixTime());
            }

            if(requestValue.InactiveTime != null)
            {
                filter.Append("|");
                filter.Append("inactive_time:");
                filter.Append(requestValue.InactiveTime.AddHours(-8).ToUnixTime());
            }

            if(requestValue.ExtFilter != null && requestValue.ExtFilter.Count > 0)
            {
                foreach(var item in requestValue.ExtFilter)
                {
                    filter.Append("|");
                    filter.Append(item.Key + ":");
                    filter.Append(item.Value);
                }
            }

            request.AddParameter("filter", filter.ToString());

            request.AddParameter("coord_type_output", (requestValue.CoordType.GetEnumDescription<CoordType>()));
            request.AddParameter("page_index", requestValue.Index);
            request.AddParameter("page_size", requestValue.Size);

            return await Client.GetAsync<ListTerminalReply>(request);
        }

        public async Task<UpdateTerminalReply> UpdateAsync(UpdateTerminalRequest requestValue)
        {
            Condition.Requires(requestValue.Name, nameof(requestValue.Name))
                .IsNotNull()
                .IsNotEmpty()
                .IsShorterOrEqual(128)
                .IsWordOrNumberOrLine();

            Condition.Requires(requestValue.Description, nameof(requestValue.Description))
                .IsShorterOrEqual(128)
                .IsWordOrNumberOrLine();

            var request = new RestRequest("/entity/update", Method.POST);
            request.AddParameter("entity_name", requestValue.Name);
            request.AddParameter("entity_desc", requestValue.Description);
            if (requestValue.Ext != null && requestValue.Ext.Count > 0)
            {
                foreach (var item in requestValue.Ext)
                {
                    request.AddParameter(item.Key, item.Value, ParameterType.RequestBody);
                }
            }

            return await Client.PostAsync<UpdateTerminalReply>(request);
        }
    }
}
