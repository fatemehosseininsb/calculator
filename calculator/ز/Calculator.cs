using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ز
{
    class Calculator : Calculate
    {
        int Calculate.divide(int number1, int number2)
        {
            return number1 / number2;
        }

        int Calculate.minuse(int number1, int number2)
        {
            return number1 - number2;
        }

        int Calculate.multiple(int number1, int number2)
        {
            return number1* number2;
        }

        int Calculate.sum(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
