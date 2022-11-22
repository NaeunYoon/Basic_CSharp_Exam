using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_80
{
    /*
     인덱서 : 배열의 요소에 접근할 떄 다음과 같은 구문을 사용할 수 있다
              클래스가 직관적으로 배열처럼 다뤄질 수 있을 때 사용하기 쉽도록 제공되는 구문              
     */

    class IntegerText
    {
        char[] txtNumebr;

        public IntegerText(int number)
        {
            //int 32 타입을 system.string 으로 변환, 다시 string에서 char 배열로 변환
            this.txtNumebr = number.ToString().ToCharArray();
        }

        public char this[int index] //인덱서를 사용해 숫자의 자릿수에 따른 문자를 반환하거나 치환
        {
            get
            {
                //1의 자릿수는 숫자에서 가장 마지막 단어를 뜻하므로, 역으로 인덱스를 다시 계산
                return txtNumebr[txtNumebr.Length - index-1];
            }

            set
            {
                //특정 자릿수를 숫자에 해당하는 문자로 치환 가능
                txtNumebr[txtNumebr.Length - index - 1] = value;
            }
        }

        public override string ToString()
        {
            return new string(txtNumebr);
        }

        public int ToInt32()
        {
            return Int32.Parse(ToString());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //기존의 방식
            int[] intArray = new int[5];
            intArray[0] = 6;
            //
            IntegerText aInt = new IntegerText(123456);

            int step = 1;
            for (int i = 0; i < aInt.ToString().Length; i++)
            {
                Console.WriteLine(step +"의 자릿수 : " + aInt[i]);
                step *= 10;
            }
            aInt[3] = '5';

            Console.WriteLine(aInt.ToInt32());

        }
    }
}
