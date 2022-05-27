using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonVersion1 firstObject = SingletonVersion1.GetInstance;
            Console.ForegroundColor = ConsoleColor.White;
            firstObject.PrintDetails("Created first instance from one object.");
            SingletonVersion1 secondObject = SingletonVersion1.GetInstance;
            Console.ForegroundColor = ConsoleColor.Red;
            secondObject.PrintDetails("Creating second instance by creating second object.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ouput clearly shows that the private constructor is executed once.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Even though constructor is called by two different objects.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This version is not thread safe.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("If both threads get instance null, private constructor will called twice.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Real Time Example :Service Proxies,Database Connection Class,Logger,");
            Console.ReadLine();
        }
    }
}
