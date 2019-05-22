using System;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            Singleton instance1 = Singleton.Instance();
            Singleton instance2 = Singleton.Instance();

            if (instance1 == instance2)
                Console.WriteLine("You can have only one instance of the entity");

            Console.ReadKey();
        }
    }
}
