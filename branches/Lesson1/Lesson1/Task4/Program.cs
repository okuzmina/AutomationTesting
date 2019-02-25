using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first row: ");
            string row1 = Console.ReadLine();

            Console.Write("Enter second row: ");
            string row2 = Console.ReadLine();

            Console.Write("Enter character: ");
            string ch = Console.ReadLine();

            string conc = row1 + row2;
            int index = conc.LastIndexOf(ch);

            Console.WriteLine();
            Console.WriteLine("Index of " + ch + " in " + conc + ": " + index);
            Console.ReadKey();
        }
    }
}
