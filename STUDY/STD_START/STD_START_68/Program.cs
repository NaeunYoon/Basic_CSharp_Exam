using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_68
{
    struct Vector
    {
        public int x;
        public int y;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int v1 = 5;
            int v2 = 10;

            SwapValue(ref v1, ref v2);
            Console.WriteLine("v1 : "+v1+" v2 :"+v2);

            //---------------------------------------------

            int value1; //값이 없으므로 ref 인자로 전달 안됨
            string text = null; //null값을 가지므로 ref 인자로 전달 가능
            int value2; //메서드 호출 전에 값을 가진다면 ref 인자로 전달 가능
            value2 = 5;

            Vector vt;
            vt.x = 5; //y값이 초기화 되지 않았으므로 ref 안됨

            Vector v3 = new Vector();   //ref 인자 전달 가능
        }


        static void SwapValue(ref int v1, ref int v2)
        {
            int tmp = v1;
            v1 = v2;
            v2 = tmp;
        }
    }
}
