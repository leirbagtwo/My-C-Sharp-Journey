using System;

namespace Giraffe1
{
    class Program
    {

        static void Main(string[] args)
        {
            int upper = 0, lower = 0;
            int number = 0, special = 0;
            int spaces = 0, sum = 0;
        
            Console.WriteLine("Enter Characters: ");
            String str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if ((str[i] >= '0') && (str[i] <= '9'))
                {
                    sum += (str[i] - '0');
                    number++;
                }
                else if (ch >= 'A' && ch <= 'Z')
                    upper++;
                else if (ch >= 'a' && ch <= 'z')
                    lower++;
                else if (ch >= ' ' && ch <= ' ')
                    spaces++;
                else
                    special++;
            }
            Console.WriteLine("Total Upper case letters in a string are: " + upper);
            Console.WriteLine("Total Lower case letters in a string are: " + lower);
            Console.WriteLine("Total number in a string are: " + number);
            Console.WriteLine("Total of special characters in a string are: " + special);
            Console.WriteLine("Total of spaces in a string are: " + spaces);
            Console.WriteLine("Sum of Intergers:  " + sum);
        }
    }
}
