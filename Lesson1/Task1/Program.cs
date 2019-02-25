using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0, z = 0;

            Console.Write("Enter X: ");
            string xInput = Console.ReadLine();
            while (!double.TryParse(xInput, out x))
            {
                Console.Write("Integer required! Try again: ");
                xInput = Console.ReadLine();
            }

            Console.Write("\r\nEnter Y: ");
            string yInput = Console.ReadLine();
            while (!double.TryParse(yInput, out y))
            {
                Console.Write("Integer required! Try again: ");
                yInput = Console.ReadLine();
            }

            Console.Write("\r\nEnter Z: ");
            string zInput = Console.ReadLine();
            while (!double.TryParse(zInput, out z))
            {
                Console.Write("Integer required! Try again: ");
                zInput = Console.ReadLine();
            }

            double result1 = (x + y) * (Math.Pow(z,2) + 1);
            double result2 = (x % z - 1) * Math.Sqrt(y);
            double result3 = ((x * y + y * z) / Math.Pow(z,3));

            Console.WriteLine();
            Console.WriteLine("First expression result: " + result1);
            Console.WriteLine("Second expression result: " + result2);
            Console.WriteLine("Third expression result: " + result3);
            Console.ReadKey();
        }
    }
}
