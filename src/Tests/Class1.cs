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

            var indexOf = p.IndexOf(',');
            if (indexOf != -1)
            {
                var first = p.Substring(0, indexOf);
                var second = p.Substring(indexOf + 1);

                var firstNum = int.Parse(first);
                var secondNum = int.Parse(second);
                return firstNum + secondNum;
            }

            return int.Parse(p);
        }
    }
}
