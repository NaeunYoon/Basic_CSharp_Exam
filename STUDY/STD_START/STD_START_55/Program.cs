using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_55
{
    interface IWeekend
    {
        void LazyDay();
    }

    class Saturday : IWeekend
    {
        public void LazyDay() { Console.WriteLine("Saturday"); }
    }

    class Sunday : IWeekend
    {
        public void LazyDay() { Console.WriteLine("Sunday"); } 
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //상속으로서의 인터페이스

            IWeekend[] instances = new IWeekend[] { new Saturday(), new Sunday() };
            
            foreach(IWeekend item in instances)
            {
                item.LazyDay(); //인터페이스를 상속받은 객체의 LazyDay 메서드가 호출된다
            }

            //자식클래스로부터 암시적 형변환 가능
            IWeekend instance = new Sunday();
            instance.LazyDay(); //=>SunDay

            }
        }
    }

