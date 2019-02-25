using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = 0, height = 0, length = 0;

            Console.Write("Enter width: ");
            string widthInput = Console.ReadLine();
            while (!double.TryParse(widthInput, out width))
            {
                Console.Write("Integer required! Try again: ");
                widthInput = Console.ReadLine();
            }

            Console.Write("\r\nEnter height: ");
            string heightInput = Console.ReadLine();
            while (!double.TryParse(heightInput, out height))
            {
                Console.Write("Integer required! Try again: ");
                heightInput = Console.ReadLine();
            }

            Console.Write("\r\nEnter length: ");
            string lengthInput = Console.ReadLine();
            while (!double.TryParse(lengthInput, out length))
            {
                Console.Write("Integer required! Try again: ");
                lengthInput = Console.ReadLine();
            }

            var result = Math.Sqrt((Math.Pow(width,2) + Math.Pow(height,2) + Math.Pow(length,2)));

            Console.WriteLine();
            Console.Write("Parallelepiped diagonal length: " + result);
            Console.ReadKey();
        }
    }
}
