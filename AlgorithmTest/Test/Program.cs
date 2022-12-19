using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class A
    {

        public void Test1()
        {
            Console.WriteLine("A");
        }
    }

    class B :A
    {
        public void Test2()
        {
            Console.WriteLine("B");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            A obj = new B();
            obj.Test1();    



        }
    }
}
