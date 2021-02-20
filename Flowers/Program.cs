using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            int chrysanthemum = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int tulip = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holliday = Console.ReadLine();

            double chrysanthemiumPrice = 0;
            double rosePrice = 0;
            double tulipPrice = 0;



            switch (season)
            {
                case "Spring":
                case "Summer":
                    chrysanthemiumPrice = 2.00;
                    rosePrice = 4.10;
                    tulipPrice = 2.50;
                    break;
                case "Autumn":
                case "Winter":
                    chrysanthemiumPrice = 3.75;
                    rosePrice = 4.50;
                    tulipPrice = 4.15;
                    break;
            }

            double totalPrice = (chrysanthemum * chrysanthemiumPrice) + (rose * rosePrice) + (tulip * tulipPrice);

            if (holliday == "Y")
            {
                totalPrice += totalPrice * 0.15;
            }

            if (rose >= 10 && season == "Winter")
            {
                totalPrice -= totalPrice * 0.10;
            }

            if (tulip > 7 && season == "Spring")
            {
                totalPrice -= totalPrice * 0.05;
            }

            if ((chrysanthemum + rose + tulip) > 20)
            {
                totalPrice -= totalPrice * 0.20;
            }

            totalPrice += 2.00;

            Console.WriteLine($"{totalPrice:f2}");


        }
    }
}
