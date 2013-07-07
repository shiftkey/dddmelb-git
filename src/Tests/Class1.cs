using System.Linq;
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

        [Fact]
        public void Add_Three_Numbers()
        {
            Assert.Equal(6, Add("1,2,3"));
        }

        int Add(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            var values = input.Split(',');

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

            return int.Parse(input);
        }
    }
}
