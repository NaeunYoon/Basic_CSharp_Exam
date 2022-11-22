using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_74
{
    enum CalcType
    {
        ADD,
        MINUS,
        MULTIPLY,
        DIVIDE,
    }

    internal class Program
    {
        public static int Calc(CalcType opType, int operand1, int operand2)
        {
            switch (opType)
            {
                case CalcType.ADD: return operand1 + operand2;
                case CalcType.MINUS: return operand1 - operand2;
                case CalcType.MULTIPLY: return operand1 * operand2;
                case CalcType.DIVIDE: return operand1 / operand2;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Calc(CalcType.ADD, 5, 6);   //enum 인스턴스로 전달
        }
    }
}
