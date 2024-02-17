using System;

namespace Arithprog
{
    class Program
    {
        static void Main(string[] args)
        {

            int op1 = 18;
            int op2 = 12;
            int answer;
            
            answer =  op1+op2;
            Console.WriteLine("Sum is {0}", answer);

            answer = op1 - op2;
            Console.WriteLine("Difference is {0}", answer);

            answer = op1 * op2;
            Console.WriteLine("Product is {0}", answer);

            answer = op1 / op2;
            Console.WriteLine("Quotient is {0}", answer);

            answer = op1 % op2;
            Console.WriteLine("Remainder is {0}", answer);

            Console.ReadLine();
        }
    }
}
