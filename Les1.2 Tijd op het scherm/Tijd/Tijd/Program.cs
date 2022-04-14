using System;
using System.Threading;

namespace Tijd
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string tijd = DateTime.Now.ToString("HH:mm:ss");

                Console.Clear();
                Console.ForegroundColor = (ConsoleColor.Magenta);
                Console.WriteLine(tijd);
                Thread.Sleep(1000);
            }
            
        }
    }
}
