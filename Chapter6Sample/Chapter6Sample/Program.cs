using System;

namespace Chapter6Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            string FullName = "Gabriel F. Daniot";
            int Age = 21;
            double Hsalary = 22.74;
            Console.WriteLine("Full name: {0}", FullName);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Distance {0}", Hsalary);
            Console.WriteLine("\nName: {0}\nage: {1}\nDistance: {2}", FullName, Age, Hsalary);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
