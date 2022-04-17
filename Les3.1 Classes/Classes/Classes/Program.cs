using System;

namespace Classes
{
    class Rekenmachine
    {
        int a = 2;
        int b = 5;
        public int plus()
        {
            return (a + b);
        }
        public int divide()
        {
            return (a / b);
        }
        public int min()
        {
            return (a * b);
        }
    }
}
/*    class Rekenmachine
    {
        static void Main(string[] args)
        {
            int rek = 2;
            int a = 9;
            int b = 3;

            switch (rek)
            {
                case 0:
                    Console.WriteLine(a + b);
                    break;
                case 1:
                    Console.WriteLine(a * b);
                    break;
                case 2:
                    Console.WriteLine(a / b);
                    break;
            }
        }

    }*/