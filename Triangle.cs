using System;
using System.Collections.Generic;
using System.Text;

namespace th4
{
    class Triangle
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public void TestTriangle()
        {
            if (x == y && x == z)
            {
                Console.WriteLine("The triangle is equilateral");
            }
            else if (x == y || x == z || y == z)
            {
                Console.WriteLine("The triangle is isosceles");
            }
            else
            {
                Console.WriteLine("The triangle is scalene");
            }
        }
    }
}
