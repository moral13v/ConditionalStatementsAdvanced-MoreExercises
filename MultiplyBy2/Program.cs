using System;

namespace MultiplyBy2
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                double num = double.Parse(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine($"Negative number!");
                    break;
                }

                Console.WriteLine($"Result: {(num * 2):f2}");
               
            }

            
        }
    }
}
