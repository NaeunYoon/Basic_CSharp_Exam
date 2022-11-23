using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_82
{
    internal class Program
    {
        class Nothing
        {
            int a;

            public int A
            {
                get { return a; }
                set { a = value; }
            }
        }


        static void Main(string[] args)
        {
            short a = 1;
            int b = 2;
            //b = a;
            a = (short)b;
            Console.WriteLine(a);

            if (b is int)
            {
                Console.WriteLine("b는 string");
            }

            ACLASS A=new ACLASS();
            BCLASS B = A as BCLASS;
            if (B == null)
            {
                Console.WriteLine("실패");
            }

            Console.WriteLine("다형성");

            Parents parent = new Parents();
            OnlyChild only = new OnlyChild();
            parent.Family();
            Parents parents = only;
            parents.Family();

            //참조형식

            //값형식

            

        }

        class ACLASS
        {

        }
        class BCLASS : ACLASS
        {

        }

        class Parents
        {
            public virtual void Family()
            {
                Console.WriteLine("자수성가한 부모님");
            }
        }

        class OnlyChild : Parents
        {
            public override void Family()
            {
                Console.WriteLine("의 고명딸");
            }
        }


    }
}
