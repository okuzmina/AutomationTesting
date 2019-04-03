using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            CarParts wheel = new CarParts("Wheel", 160);
            CarParts headlight = new CarParts("Headlight", 30);
            CarParts bumper = new CarParts("Bumper", 90);
            CarParts dashboard = new CarParts("Daqshboard", 70);
            CarParts engine = new CarParts("Engine", 500);
            Car kia = new Car("KIA", new CarParts[] {wheel, headlight, bumper});
            Car vw = new Car("VW", new CarParts[] { wheel, engine});
            Car opel = new Car("OPEL", new CarParts[] {wheel, dashboard, bumper});

            Console.Write("Enter one of the car names Kia, VW or Opel: ");
            string carInput = Console.ReadLine().ToLower();

            switch (carInput)
            {
                case "kia":
                    {
                        Console.Write("Summary cost of parts is: {0}", Calculator.Calculate(kia));
                        break;
                    }
                case "vw":
                    {
                        Console.Write("Summary cost of parts is: {0}", Calculator.Calculate(vw));
                        break;
                    }
                case "opel":
                    {
                        Console.Write("Summary cost of parts is: {0}", Calculator.Calculate(opel));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Undefined car");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}