using System;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double price = 0;

            // condition 1

            switch (category)
            {
                case "VIP":
                    price = 499.99;
                    break;
                case "Normal":
                    price = 249.99;
                    break;
            }

            double transport = 0;

            // condition 2

            if (people >= 1 && people <= 4)
            {
                transport = budget * 0.75;
            }

            else if (people <= 9)
            {
                transport = budget * 0.60;
            }

            else if (people <= 24)
            {
                transport = budget * 0.50;
            }

            else if (people <= 49)
            {
                transport = budget * 0.40;
            }

            else if (people >= 50)
            {
                transport = budget * 0.25;
            }

            // condition 3

            if (budget >= ((price * people) + transport))
            {
                Console.WriteLine($"Yes! You have {(budget - (price * people) - transport):f2} leva left.");
            }

            else
            {
                Console.WriteLine($"Not enough money! You need {(((price * people) + transport) - budget):f2} leva.");
            }
            


        }
    }
}
