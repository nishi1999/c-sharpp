using System;

namespace interface_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator bc = new BasicCalculator();
            ScientificCalculator sc = new ScientificCalculator();

            Console.WriteLine("Basic calculator operatrions");
           
            Console.WriteLine(bc.sum(100, 5));
            Console.WriteLine(bc.sub(50, 5));
            Console.WriteLine(bc.multiplication(50, 5));
            Console.WriteLine(bc.division(10, 5));

            Console.WriteLine("");


            Console.WriteLine("Scientific calculator operatrions");
           
            Console.WriteLine(sc.sum(15, 5));
            Console.WriteLine(sc.sub(30, 5));
            Console.WriteLine(sc.multiplication(10, 5));
            Console.WriteLine(sc.division(15, 5));
            Console.WriteLine(sc.XtoY(100, 5));
            Console.WriteLine(sc.sin(0));


        }
    }
}

