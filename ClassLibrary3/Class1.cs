using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClassLibrary3
{
    public class Class1
    {
        [Fact]
        public Task Foo()
        {
            Assert.True(true);
            return Task.FromResult(0);
        }
    }
}
