using System;

namespace LogOpProg2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            number += 5;
            Console.WriteLine(number);

            number -= 3;
            Console.WriteLine(number);

            number *= 2;
            Console.WriteLine(number);

            number /= 3;
            Console.WriteLine(number);

            number %= 3;
            Console.WriteLine(number);

            number &= 10;
            Console.WriteLine(number);

            number |= 14;
            Console.WriteLine(number);

            number ^= 12;
            Console.WriteLine(number);

            number <<= 2;
            Console.WriteLine(number);

            number >>= 3;
            Console.WriteLine(number);
        }
    }
}
