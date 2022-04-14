using System;
using System.Threading;

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string text = "Hello World <3";
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(1000);
            }
        }
    }
}