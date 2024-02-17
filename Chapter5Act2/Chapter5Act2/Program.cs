using System;

namespace Chapter5Act2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 12, y = 18,result;


            result = y + 20;
            Console.WriteLine("Result is x = "+ result);

            result = y - 20;
            Console.WriteLine("Result is x = "+ result);

            result = y * 20;
            Console.WriteLine("Result is x = "+ result);

            result = x / y;
            Console.WriteLine("Result is x = "+ result);

            result = x % y;
            Console.WriteLine("Result is x = "+ result);
            Console.ReadKey();

                
        }
    }
}
