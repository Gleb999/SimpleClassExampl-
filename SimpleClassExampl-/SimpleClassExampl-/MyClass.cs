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

        public MyClass() { }

        public MyClass(string name)
        : this  ("Artur"){ }

        public MyClass(int age)
        : this (30) { }

        public MyClass(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.", Name, Age);
        }


    }
}
