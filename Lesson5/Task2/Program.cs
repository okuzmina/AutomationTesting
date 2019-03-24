using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Car carInput = new Car();

            Console.Write("Enter one of the car names Kia, VW or Opel: ");
            carInput.Name = Console.ReadLine().ToLower();

            Console.Write("Summary cost of parts is: {0}", carInput.Cost(carInput.Parts(carInput.Name)));
            Console.ReadKey();
        }
    }
}