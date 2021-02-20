using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            int junior = int.Parse(Console.ReadLine());
            int senior = int.Parse(Console.ReadLine());
            string venue = Console.ReadLine();

            double juniorPrice = 0;
            double seniorPrice = 0;


            // condition 1

            switch (venue)
            {
                case "trail":
                    juniorPrice = 5.50;
                    seniorPrice = 7;
                    break;
                case "cross-country":
                    juniorPrice = 8;
                    seniorPrice = 9.50;
                    if ((junior + senior) >= 50)
                    {
                        juniorPrice -= juniorPrice * 0.25;
                        seniorPrice -= seniorPrice * 0.25;
                    }
                    break;
                case "downhill":
                    juniorPrice = 12.25;
                    seniorPrice = 13.75;
                    break;
                case "road":
                    juniorPrice = 20;
                    seniorPrice = 21.50;
                    break;

            }

            double income = (junior * juniorPrice) + (senior * seniorPrice);
            income -= income * 0.05;


            
            Console.WriteLine($"{income:f2}");

        }
    }
}
