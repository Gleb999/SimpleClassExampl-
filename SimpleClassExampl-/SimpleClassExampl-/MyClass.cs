using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExampl_
{
    class MyClass
    {
        public string Name;
        public int Age;

        public MyClass()
        {
            Name = "Mark";
            Age = 19;
        }

        public MyClass(string pn)
        {
            Name = pn;
        }

        public MyClass(string pn, int cs)
        {
            Name = pn;
            Age = cs;

        }

        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.", Name, Age);
        }
    }
}
