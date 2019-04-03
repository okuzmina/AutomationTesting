using System;

namespace Lesson5
{
    class Program
    {
        static int Check()
        {
            int checkedInput = 0;
            string input = Console.ReadLine();
            while (!Int32.TryParse(input, out checkedInput))
            {
                Console.Write("Integer required! Try again: ");
                input = Console.ReadLine();
            }

            return checkedInput;
        }

        static void Main()
        {
            Console.Write("Enter the first side: ");
            int side1 = Check();

            Console.Write("\nEnter the second side: ");
            int side2 = Check();

            Rectangle myRectangle = new Rectangle(side1, side2);

            Console.WriteLine("\nArea of the rectangle: {0}", myRectangle.AreaCalculator());
            Console.WriteLine("Perimetr of the rectangle: {0}", myRectangle.PerimetrCalculator());
            Console.ReadKey();
        }
    }
}

