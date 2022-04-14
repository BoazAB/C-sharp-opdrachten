using System;

namespace scopes
{
    class Program
    {

        static void Main(string[] args)
        {
            cat();
        }
        static public void cat()
        {
            for (int i = 0; i <= 10; i = i + 1)
            {
                Console.WriteLine("mjouw");
            }
        }
    }
}