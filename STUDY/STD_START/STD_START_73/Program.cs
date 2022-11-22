using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_73
{
    internal class Program
    {
        public static int Calc(char opType, int operand1, int operand2)
        {
            switch (opType)
            {
                case '+': return operand1 + operand2;
                case '-': return operand1 - operand2;
                case '*': return operand1 * operand2;
                case '/': return operand1 / operand2;
            }
            return 0;
        }
        


        static void Main(string[] args)
        {
            Calc('+', 5, 6); //더하기 연산을 수행하도록 '+'를 전달
        }
    }
}
