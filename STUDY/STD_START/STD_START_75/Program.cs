using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_75
{
        /*
         readonly : 읽기 전용 필드 ( 한 번만 값을 쓴 후, 다시 값을 설정 못하게 만듬)
                    변수를 정의할 떄와 생성자 내부를 제외하고는 그 값을 바꾸는 시도를 할 수 없다
         */
    public class Scheduler
    {
        readonly int second = 1;    //읽기 전용 필드 정의 및 값을 대입
        readonly string name;   //읽기 전용 필드 정의

        public Scheduler()
        {
            this.name = "일정관리"; //읽기 전용 필드는 생성자에서 대입 가능
        }

        public void Run()
        {
            /*this.second = 5;*/    //컴파일 오류 : 일반 메서드에서 값을 대입할 수 없다
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
