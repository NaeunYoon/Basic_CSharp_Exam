using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_62
{
    //느슨한 결합 : 클래스간에 구현 타입의 정보 없이 인터페이스 등의 방법을 이용해 
    //상호간에 맺은 계약만으로 동작하는 것

    interface IPower
    {
        void TurnOn();
    }

    class Monitor : IPower
    {
        public void TurnOn()
        {
            Console.WriteLine("Monitor : TurnOn");
        }
    }

    class Switch
    {
        public void PowerOn(IPower machine)
        {
            machine.TurnOn();
        }
    }
        

    //class Computer
    //{
    //    public void TurnOn()
    //    {
    //        Console.WriteLine("Computer : TurnOn");
    //    }
    //}

    //class Switch
    //{
    //    public void PowerOn(Computer machine)
    //    {
    //        machine.TurnOn();
    //    }
    //}

    //class Monitor
    //{
    //    public void TurnOn()
    //    {
    //        Console.WriteLine("Monitor : TurnOn");
    //    }
    //}

    //class Switch
    //{
    //    public void PowerOn(Monitor machine)
    //    {
    //        machine.TurnOn();
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {

    //    }
    //}
}
