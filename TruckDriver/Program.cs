using System;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            // variables

            double pricePerKm = 0;

            // conditions

            switch (season)
            {
                case "Spring":
                case "Autumn":
                    if (kmPerMonth <= 5000)
                    {
                        pricePerKm = 0.75;
                    }

                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        pricePerKm = 0.95;
                    }
                    break;
                case "Summer":
                    if (kmPerMonth <= 5000)
                    {
                        pricePerKm = 0.90;
                    }

                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        pricePerKm = 1.10;
                    }
                    break;
                case "Winter":
                    if (kmPerMonth <= 5000)
                    {
                        pricePerKm = 1.05;
                    }

                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        pricePerKm = 1.25;
                    }
                    break;
            }

            if (kmPerMonth > 10000 && kmPerMonth <= 20000)
            {
                pricePerKm = 1.45;
            }

            // calculations

            double salary = kmPerMonth * pricePerKm * 4 * 0.9;

            // output

            Console.WriteLine($"{salary:f2}");

        }
    }
}
