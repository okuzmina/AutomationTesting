using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Z: ");
            int z = Convert.ToInt32(Console.ReadLine());

            var result1 = (x + y) * (Math.Pow(z,2) + 1);
            var result2 = (x % z - 1) * Math.Sqrt(y);
            var result3 = ((x * y + y * z) / Math.Pow(z,3));

            Console.WriteLine();
            Console.WriteLine("First expression result: " + result1);
            Console.WriteLine("Second expression result: " + result2);
            Console.WriteLine("Third expression result: " + result3);
            Console.ReadKey();
        }
    }
}
