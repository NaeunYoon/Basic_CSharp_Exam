using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_61
{
    class Hardware { }

    class USB
    {
        string name;
        public USB(string name) //생성자
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }

    class Notebook  : Hardware, IEnumerable //IEnumerable 인터페이스 구현
    {
        USB[] usbList = new USB[] { new USB("usb1"), new USB("usb2") };
        public IEnumerator GetEnumerator()  //IEnumerator 를 구현한 열거자 인스턴스 반환
        {
            return new USBEnumerator(usbList);
        }
    }

    class USBEnumerator : IEnumerator   //중첩클래스로 정의된 열거자 타입
    {
        int pos = -1;
        int length = 0;
        object[] list; 

        public USBEnumerator(USB[] usb)
        {
            list = usb;
            length = usb.Length;
        }

        public object Current   //1. 현재 요소를 반환하도록 약속된 접근자 메서드(get)
        {
            get { return list[pos]; }
        }

        public bool MoveNext()  //2. 다음 순서의 요소를 지정하도록 약속된 메서드
        {
            if(pos>=length - 1)
            {
                return false;
            }
            pos++;
            return true;
        }

        public void Reset() //3. 처음부터 열거하고 싶을 떄 호출하면 되는 메서드
        {
            pos = -1;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            foreach(USB usb in notebook)
            {
                Console.WriteLine(usb);
            }
        }
    }
}
