using System;

namespace LogOpProg
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int firstNumber = 10, secondNumber = 20;

            result = (firstNumber == secondNumber) || (firstNumber > 5);
            Console.WriteLine(result);

            result = (firstNumber == secondNumber) && (firstNumber > 5);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
