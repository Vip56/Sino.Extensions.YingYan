using Sino.Extensions.YingYan.Terminal;
using Sino.Extensions.YingYan.Utils;
using System;
using System.Threading.Tasks;
using Xunit;

namespace YingYanUnitTest
{
    public class TerminalUnitTest : BaseTest
    {
        protected ITerminalManager Manager { get; set; }

        public TerminalUnitTest() : base()
        {
            Manager = new TerminalManager(Client);
        }

        [Fact]
        public async Task Add_With_Success_Test()
        {
            var request = new AddTerminalRequest();
            request.Name = Guid.NewGuid().ToString();
            request.Description = "≤‚ ‘ ˝æ›";
            var response = await Manager.AddAsync(request);

            Assert.NotNull(response);
            Assert.Equal(0, response.Status);
        }
    }
}
