using Sino.Extensions.YingYan.Utils;

namespace YingYanUnitTest
{
    public abstract class BaseTest
    {
        protected HttpUtil Client { get; set; }

        public BaseTest()
        {
            Client = new HttpUtil("http://yingyan.baidu.com/api/v3", "yFOabSfEtYS8NvpmNnqzsnLa1Nj7GVg7", "122030");
        }
    }
}
