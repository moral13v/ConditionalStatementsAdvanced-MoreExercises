using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            // variables

            string accomodation = "";
            string destination = "";
            double price = 0;

            // conditions

            if (budget <= 1000)
            {
                accomodation = "Camp";

                switch (season)
                {
                    case "Summer":
                        destination = "Alaska";
                        price = budget * 0.65;
                        break;
                    case "Winter":
                        destination = "Morocco";
                        price = budget * 0.45;
                        break;
                }
            }

            else if (budget > 1000 && budget <= 3000)
            {
                accomodation = "Hut";

                switch (season)
                {
                    case "Summer":
                        destination = "Alaska";
                        price = budget * 0.80;
                        break;
                    case "Winter":
                        destination = "Morocco";
                        price = budget * 0.60;
                        break;
                }
            }

            else if (budget > 3000)
            {
                accomodation = "Hotel";
                price = budget * 0.90;

                switch (season)
                {
                    case "Summer":
                        destination = "Alaska";
                        break;
                    case "Winter":
                        destination = "Morocco";
                        break;
                }

            }

            // output

            Console.WriteLine($"{destination} - {accomodation} - {price:f2}");
        }
    }
}