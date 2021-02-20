using System;

namespace PointOnRectangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            // variables

            bool firstCondition = (x == x1 || x == x2) && (y >= y1 && y <= y2);
            bool secondCondition = (y == y1 || y == y2) && (x >= x1 && x <= x2);

            // conditions

            if (firstCondition || secondCondition)
            {
                Console.WriteLine("Border");
            }

            else Console.WriteLine("Inside / Outside");
        }
    }
}
