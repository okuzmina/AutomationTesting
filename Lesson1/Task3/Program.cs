using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first row: ");
            string row1Upper = Console.ReadLine().ToUpper();

            Console.Write("Enter second row: ");
            string row2Upper = Console.ReadLine().ToUpper();

            Console.Write("Enter third row: ");
            string row3Upper = Console.ReadLine().ToUpper();

            Console.WriteLine();
            Console.WriteLine("String " + row1Upper + " starts from " + row2Upper + ": " + row1Upper.StartsWith(row2Upper));
            Console.WriteLine("String " + row1Upper + " ends with " + row3Upper + ": " + row1Upper.EndsWith(row3Upper));
            Console.ReadKey();
        }
    }
}
