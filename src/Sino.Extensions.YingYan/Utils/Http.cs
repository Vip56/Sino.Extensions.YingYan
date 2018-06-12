using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sino.Extensions.YingYan.Utils
{
    public class HttpUtil
    {
        public RestClient Client { get; set; }

        public bool UseSN { get; set; } = false;

        private string _ak;
        private string _serviceid;

        public HttpUtil(string url, string ak, string serviceId)
        {
            Client = new RestClient(url);
            _ak = ak;
            _serviceid = serviceId;
        }

        public Task<T> GetAsync<T>(RestRequest request) where T : new()
        {
            return Task<T>.Factory.StartNew(() =>
            {
                request.AddQueryParameter("ak", _ak);
                request.AddQueryParameter("service_id", _serviceid);
                if(UseSN)
                {
                    //暂未实现
                }
                var response = Client.Execute<T>(request);
                if (response.IsSuccessful)
                {
                    HandleException(request, response);
                }
                return response.Data;
            });
        }

        public Task<T> PostAsync<T>(RestRequest request) where T : new()
        {
            return Task<T>.Factory.StartNew(() =>
            {
                request.RequestFormat = DataFormat.Json;
                request.AlwaysMultipartFormData = true;
                request.AddParameter("ak", _ak);
                request.AddParameter("service_id", _serviceid);
                if (UseSN)
                {

                }
                var response = Client.Execute<T>(request);
                if(!response.IsSuccessful)
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
