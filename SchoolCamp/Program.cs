using System;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            string season = Console.ReadLine();
            string gender = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            // variables

            double price = 0;
            string sport = "";

            // condition 1

            switch (season)
            {
                case "Winter":
                    switch (gender)
                    {
                        case "boys":
                            price = 9.60;
                            sport = "Judo";
                            break;
                        case "girls":
                            price = 9.60;
                            sport = "Gymnastics";
                            break;
                        case "mixed":
                            price = 10;
                            sport = "Ski";
                            break;
                    }
                    break;
                case "Spring":
                    switch (gender)
                    {
                        case "boys":
                            price = 7.20;
                            sport = "Tennis";
                            break;
                        case "girls":
                            price = 7.20;
                            sport = "Athletics";
                            break;
                        case "mixed":
                            price = 9.50;
                            sport = "Cycling";
                            break;
                    }
                    break;
                case "Summer":
                    switch (gender)
                    {
                        case "boys":
                            price = 15;
                            sport = "Football";
                            break;
                        case "girls":
                            price = 15;
                            sport = "Volleyball";
                            break;
                        case "mixed":
                            price = 20;
                            sport = "Swimming";
                            break;
                    }
                    break;
            }

            // condition 2

            if (students >= 50)
            {
                price *= 0.50;
            }

            else if (students >= 20 && students < 50)
            {
                price *= 0.85;
            }

            else if (students >= 10 && students < 20)
            {
                price *= 0.95;
            }

            // output

            Console.WriteLine($"{sport} {(students * price * nights):f2} lv.");
        }
    }
}
