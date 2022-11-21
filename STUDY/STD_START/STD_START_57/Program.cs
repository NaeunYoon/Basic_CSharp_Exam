using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_57
{
    interface ITostring { } //Tostring 을 재정의한 클래스에만 사용 될 빈 인터페이스 정의

    class Saturday { }  //Tostring 을 재정의하지 않은 예제 타입

    class Sunday : ITostring //Tostring을 재정의했다는 의미로 인터페이스 상속
    {
        string name;

        public Sunday(string name)  //생성자
        {
            this.name = name;
        }
        public override string ToString()
        {
            return "Sunday "+this.name;
        }
    }    
                               

    internal class Program
    {
        private static void DisplayObject(object obj)
        {
            if(obj is ITostring)    //인터페이스로 형변환이 가능한가?
            {
                Console.WriteLine(obj.ToString());
            }
        }
        static void Main(string[] args)
        {
            DisplayObject(new Saturday());  //saturday는 상속을 받지 않았음
            DisplayObject(new Sunday("윤나은"));   //sunday는 상속을 받음
        }
    }
}
