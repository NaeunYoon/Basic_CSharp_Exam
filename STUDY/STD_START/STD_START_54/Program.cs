using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_54
{
    internal class Program
    {
        interface ISpeaker
        {
            void TurnOn();
            int Inch { get; set; }  //프로퍼티 GET SET 포함
            int Width { get; }  //GET만 포함하는 것도 가능
        }

        class Laptop : ISpeaker
        {
            public void TurnOn()    //인터페이스 멤버 구현
            {             
            }

            int inch;
            public int Inch     //인터페이스 멤버 구현
            {
                get { return inch; }
                set { inch = value; }
            }

            int width;
            public int Width    //인터페이스 멤버 구현
            {
                get { return width; }
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
