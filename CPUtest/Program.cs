using System;

namespace check_how_strong_is_your_cpu
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double i = 0; i < 550500; i += 0.1)
            {
                Console.WriteLine($"{i:F2}");
            }

        }
    }

}

