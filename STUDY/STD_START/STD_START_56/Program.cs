using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_56
{
    public abstract class IWeekend
    {
        public abstract void LazyDay();
    }

    class Saturday : IWeekend
    {
        public override void LazyDay()
        {
            Console.WriteLine("Saturday");
        }
    }

    class Sunday : IWeekend
    {
        public override void LazyDay()
        {
            Console.WriteLine("Sunday");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
