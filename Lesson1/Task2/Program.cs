using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double checkedInput = 0, width = 0, height = 0, length = 0;

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

            Console.Write("Enter width: ");
            width = Check();

            Console.Write("\r\nEnter height: ");
            height = Check();

            Console.Write("\r\nEnter length: ");
            length = Check();

            var result = Math.Sqrt((Math.Pow(width,2) + Math.Pow(height,2) + Math.Pow(length,2)));

            Console.WriteLine();
            Console.Write("Parallelepiped diagonal length: " + result);
            Console.ReadKey();
        }
    }
}
