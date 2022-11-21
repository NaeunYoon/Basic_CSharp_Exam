using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
//이거 잘 모르겠어요....ㅠㅠ

namespace STD_START_59
{
    public interface IComparer
    {
        int Compare(object x, object y);    //몸통없는 함수

        //public static void Sort(Array array);
        //public static void Sort(Array array, IComparer comparer);
    }

    class IntegerCompare : IComparer
    {
        //Icompare 인터페이스의 compare 함수를 구현
        public int Compare(object x, object y)
        {
            int xValue = (int)x;
            int yValue = (int)y;

            if (xValue > yValue)
                return -1;
            else if (xValue == yValue)
                return 0;

            return 1;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            //Array.Sort(intArray, new IntegerCompare());
            foreach(int item in intArray)
            {
                Console.WriteLine(item + ",");
            }
        }
    }
}
