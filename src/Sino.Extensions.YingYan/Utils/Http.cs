using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sino.Extensions.YingYan.Utils
{
    public class Http
    {
        public RestClient Client { get; set; }

        public bool UseSN { get; set; } = false;

        private string _ak;
        private string _serviceid;

        public Http(string url, string ak, string serviceId)
        {
            Client = new RestClient(url);
            _ak = ak;
            _serviceid = serviceId;
        }

        public Task<T> Get<T>(RestRequest request) where T : new()
        {
            return Task<T>.Factory.StartNew(() =>
            {
                var response = Client.Execute<T>(request);
                if (response.IsSuccessful)
                {
                    HandleException(request, response);
                }
                return response.Data;
            });
        }

        public void HandleException(IRestRequest request, IRestResponse response)
        {

        }
    }
}
