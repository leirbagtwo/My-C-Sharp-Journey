using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, number;
            int from = 10;
            int to = 2;

            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(Convert.ToInt32(number, ), to);
            Console.WriteLine(binary);

            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (int i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
