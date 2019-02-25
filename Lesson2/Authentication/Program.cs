using System;

namespace Authentication
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "User1";
            string password = "qwe123";

            Console.Write("Enter login: ");
            string loginInput = Console.ReadLine();

            Console.Write("\rEnter password: ");
            string passwordInput = Console.ReadLine();

            if (login == loginInput && password == passwordInput)
                Console.WriteLine("\nYou have been successfully logged in");
            else
                Console.WriteLine("\nEntered login or password is invalid");

            Console.ReadKey();
        }
    }
}