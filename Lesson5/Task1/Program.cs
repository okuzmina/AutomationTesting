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
            Rectangle myRectangle = new Rectangle();

            Console.Write("Enter the first side: ");
            myRectangle.Side1 = Check();

            Console.Write("\nEnter the second side: ");
            myRectangle.Side2 = Check();

            Console.WriteLine("\nArea of the rectangle with sides {0} and {1}: {2}", myRectangle.Side1, myRectangle.Side2, myRectangle.AreaCalculator(myRectangle.Side1, myRectangle.Side2));
            Console.WriteLine("Perimetr of the rectangle with sides {0} and {1}: {2}", myRectangle.Side1, myRectangle.Side2, myRectangle.PerimetrCalculator(myRectangle.Side1, myRectangle.Side2));
            Console.ReadKey();
        }
    }
}

