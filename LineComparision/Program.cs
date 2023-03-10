using System;
namespace LineComparision
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to line calculator");
            Console.WriteLine("Enter x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            CalculateLength calculateLength = new CalculateLength(x1, y1, x2, y2);
            calculateLength.calculate();
        }
    }
}