using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class SomeClass
    {
        private string _someProperty;
        private int _anotherProperty;

        public string SomeProperty
        {
            get { return _someProperty; }
            set { _someProperty = value; }
        }

        public int AnotherProperty
        {
            get { return _anotherProperty; }
            set { _anotherProperty = value; }
        }
    }
}
