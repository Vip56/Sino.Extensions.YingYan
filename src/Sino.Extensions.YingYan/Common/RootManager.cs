using Sino.Extensions.YingYan.Utils;

namespace Sino.Extensions.YingYan
{
    public abstract class RootManager
    {
        protected HttpUtil Client { get; set; }

        public RootManager(HttpUtil http)
        {
            Client = http;
        }
    }
}
