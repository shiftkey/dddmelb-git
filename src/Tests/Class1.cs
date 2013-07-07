using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class Class1
    {
        [Fact]
        public void Add_An_Empty_String()
        {
            Assert.Equal(0, Add(""));
        }

        int Add(string p)
        {
            return 0;
        }
    }
}
