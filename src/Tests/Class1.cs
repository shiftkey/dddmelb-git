using System;
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

        [Fact]
        public void Add_Three_Numbers_With_Newline()
        {
            Assert.Equal(6, Add("1,\n2,3"));
        }

        [Fact]
        public void Add_Missing_Second_Number_Throws()
        {
            Assert.Throws<ArgumentException>(() => Add("1,\n"));
        }

        int Add(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            var text = input.Replace("\n", "");

            var values = text.Split(',');

            if (values.Any())
            {
                int total = 0;
                foreach (var v in values)
                {
                    int number;
                    if (int.TryParse(v, out number))
                    {
                        total += number;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                return total;
            }

            return int.Parse(text);
        }
    }
}
