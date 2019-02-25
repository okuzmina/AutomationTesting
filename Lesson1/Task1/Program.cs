using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double checkedInput = 0, x = 0, y = 0, z = 0;

            double Check()
            {
                string input = Console.ReadLine();
                while (!double.TryParse(input, out checkedInput))
                {
                    Console.Write("Integer required! Try again: ");
                    input = Console.ReadLine();
                }
                return checkedInput;
            }

            Console.Write("Enter X: ");
            x = Check();

            Console.Write("\r\nEnter Y: ");
            y = Check();

            Console.Write("\r\nEnter Z: ");
            z = Check();

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
