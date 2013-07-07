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

        [Fact]
        public void Add_One_Number()
        {
            Assert.Equal(1, Add("1"));
        }

        [Fact]
        public void Add_Two_Numbers()
        {
            Assert.Equal(3, Add("1,2"));
        }

        int Add(string p)
        {
            if (string.IsNullOrWhiteSpace(p))
                return 0;

            var values = p.Split(',');

            if (values.Any())
            {
                int total = 0;
                foreach (var v in values)
                {
                    var value = int.Parse(v);
                    total += value;
                }
                return total;
            }

            return int.Parse(p);
        }
    }
}
