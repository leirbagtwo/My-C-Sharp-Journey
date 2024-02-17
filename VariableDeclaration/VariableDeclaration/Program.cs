using System;

namespace VariableDeclaration
{
    class Program
    {
        static void Main(string[] args)
        {
            short num1;
            int num2;

            double pi;
            double num3;

            pi = 3.141;
            num1 = 12;
            num2 = 18;
            num3 = num1 + num2;
            Console.WriteLine("The Value of PI is{0}", pi);
            Console.WriteLine("numer 1 = {0}, number 2 = {1}, number 3 =  {2}", num1, num2, num3);
            Console.ReadLine();
        }
    }
}
