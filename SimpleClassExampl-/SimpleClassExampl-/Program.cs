using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExampl_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");

            /*Car chuck = new Car();
            chuck.PrintState();

            Car mary = new Car("Mary");
            mary.PrintState();

            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();*/

            MyClass mark = new MyClass();
            mark.PrintState();

            MyClass bob = new MyClass("Bob");
            bob.PrintState();

            Car max = new Car("Max", 22);
            max.PrintState();

            Motorcycle c = new Motorcycle(40, "Artur");
            c.PopAWheely();

            Console.WriteLine("Rider name is {0}", c.name);

            Console.ReadLine();
        }
    }
}
