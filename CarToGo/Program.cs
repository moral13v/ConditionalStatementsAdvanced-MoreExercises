using System;

namespace CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            // variables

            string carClass = "";
            string carType = "";
            double carPrice = 0;


            // conditions

            switch (season)
            {
                case "Summer":
                    if (budget <= 100)
                    {
                        carClass = "Economy class";
                        carType = "Cabrio";
                        carPrice = budget * 0.35;
                    }

                    else if (budget > 100 && budget <= 500)
                    {
                        carClass = "Compact class";
                        carType = "Cabrio";
                        carPrice = budget * 0.45;
                    }

                    else if (budget > 500)
                    {
                        carClass = "Luxury class";
                        carType = "Jeep";
                        carPrice = budget * 0.90;
                    }
                    break;

                case "Winter":
                    if (budget <= 100)
                    {
                        carClass = "Economy class";
                        carType = "Jeep";
                        carPrice = budget * 0.65;
                    }

                    else if (budget > 100 && budget <= 500)
                    {
                        carClass = "Compact class";
                        carType = "Jeep";
                        carPrice = budget * 0.80;
                    }

                    else if (budget > 500)
                    {
                        carClass = "Luxury class";
                        carType = "Jeep";
                        carPrice = budget * 0.90;
                    }
                    break;
            }

            // output

            Console.WriteLine(carClass);
            Console.WriteLine($"{carType} - {carPrice:f2}");

        }
    }
}
