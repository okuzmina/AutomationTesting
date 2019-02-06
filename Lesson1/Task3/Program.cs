using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first row: ");
            string row1 = Console.ReadLine();

            Console.Write("Enter second row: ");
            string row2 = Console.ReadLine();

            Console.Write("Enter third row: ");
            string row3 = Console.ReadLine();

            string row1Upper = row1.ToUpper();
            string row2Upper = row2.ToUpper();
            string row3Upper = row3.ToUpper();

            bool a = row1Upper.StartsWith(row2Upper);
            bool b = row1Upper.EndsWith(row3Upper);

            Console.WriteLine();
            Console.WriteLine("String " + row1Upper + " starts from " + row2Upper + ": " + a);
            Console.WriteLine("String " + row1Upper + " ends with " + row3Upper + ": " + b);
            Console.ReadKey();
        }
    }
}
