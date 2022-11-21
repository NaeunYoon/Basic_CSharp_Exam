using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_58
{
    interface Isource
    {
        int GetResult();    //함수 머리만 있음
    }

    class Source : Isource
    {
        public int GetResult()
        {
            return 10;
        }    //함수 몸통 구현해줌

        public void Test()
        {
            Target target = new Target();
            target.Do(this);    //콜했음 
        }
    }

    class Target
    {
        public void Do(Isource obj)
        {
            Console.WriteLine(obj.GetResult()); //이게 콜백함수임     
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Source source = new Source();
            source.Test();
        }
    }
}
