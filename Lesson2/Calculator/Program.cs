using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1 = 0, operand2 = 0;

            Console.Write("Enter first operand: ");
            string inputOperand1 = Console.ReadLine();
            while (!double.TryParse(inputOperand1, out operand1))
            {
                Console.Write("Integer required! Try again: ");
                inputOperand1 = Console.ReadLine();
            }

            Console.Write("\r\nEnter second operand: ");
            string inputOperand2 = Console.ReadLine();
            while (!double.TryParse(inputOperand2, out operand2))
            {
                Console.Write("Integer required! Try again: ");
                inputOperand2 = Console.ReadLine();
            }

            Console.Write("\r\nEnter operation: ");
            char operation = Console.ReadKey().KeyChar;
            switch (operation)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", operand1, operand2, operand1 + operand2);
                    break;
                case '-':
                    Console.WriteLine("{0} - {1} = {2}", operand1, operand2, operand1 - operand2);
                    break;
                case '/':
                    Console.WriteLine("{0} / {1} = {2}", operand1, operand2, operand1 / operand2);
                    break;
                case '*':
                    Console.WriteLine("{0} * {1} = {2}", operand1, operand2, operand1 * operand2);
                    break;
                case '^':
                    Console.WriteLine("{0} ^ {1} = {2}", operand1, operand2, Math.Pow(operand1, operand2));
                    break;
                default:
                    Console.WriteLine("\nEntered operation doesn't exist.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
