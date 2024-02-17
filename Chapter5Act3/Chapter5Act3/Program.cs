using System;

namespace Chapter5Act3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x = 5, y = 6, z = 7;
            a = (x+y)*z;
            b = (x * y) + (y * z);

            Console.WriteLine("Result of specified {0}, {1} and {2},(x+y).z is {3} and x.y+y.z is {4}",x,y,z,a,b);
            Console.ReadKey();
        }
    }
}
