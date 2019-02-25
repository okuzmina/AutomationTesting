using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            var result = Math.Sqrt((Math.Pow(width,2) + Math.Pow(height,2) + Math.Pow(length,2)));

            Console.WriteLine();
            Console.Write("Parallelepiped diagonal length: " + result);
            Console.ReadKey();
        }
    }
}
