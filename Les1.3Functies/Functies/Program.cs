using System;

namespace Functies
{
    class Program
    {
        class hi
        {
            string hoi = "Hello World <3";

            static void Main(string[] args)
            {
                bannaan();
            }

            public static void bannaan()
            {
                hi kiwi = new hi();
                Console.WriteLine(kiwi.hoi);
            }
        }
    }
}
