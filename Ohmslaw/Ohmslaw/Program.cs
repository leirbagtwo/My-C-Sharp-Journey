using System;

namespace Ohmslaw
{
    class Program
    {
        static void Main(string[] args)
        {
            double resistance = 2.5, ampheres = 2, voltage = 0;

            voltage = ampheres * resistance;
            Console.WriteLine(voltage);
        }
    }
}
