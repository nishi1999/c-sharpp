using System;
using System.Collections.Generic;
using System.Text;

namespace interface_calculator
{
    class BasicCalculator:BasicCalculatorInterface
    {
        public int division(int x, int y)
        {
            Console.WriteLine("Division of {0} and {1} is: ", x, y);

            int div = x / y;
            return div;
        }

        public int multiplication(int x, int y)
        {

            Console.WriteLine("Multiplication of {0} and {1} is: ", x, y);
            int m = x * y;
            return m;
        }

        public int sub(int x, int y)
        {
            Console.WriteLine("Subtraction of {0} and {1} is: ", x, y);
            int sub = x - y;
            return sub;
        }

        public int sum(int x, int y)
        {
            Console.WriteLine("Summation of {0} and {1} is: ", x, y);
            int sum = x + y;
            return sum;
        }

    }
}

