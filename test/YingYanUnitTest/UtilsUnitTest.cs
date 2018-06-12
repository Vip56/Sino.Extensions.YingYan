using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace YingYanUnitTest
{
    public class UtilsUnitTest
    {
        [Fact]
        public void Get_Unix_Test()
        {
            var dt = DateTime.Parse("2018/6/7 16:46:9");
            dt = dt.AddHours(-8);
            long timestamp = dt.ToUnixTime();

            Assert.Equal(1528361169, timestamp);
        }
    }
}
