using System;

namespace Classes
{
    class Rekenmachine
    {
        static void Main()
        {
            Console.WriteLine("0 = +, 1 = /, 2 = * ");
            string input = Console.ReadLine();

            int rek = Int32.Parse(input);
            Rekenmachine rekenmachine = new Rekenmachine();
            switch (rek)
            {
                case 0:
                    rekenmachine.plus();
                    break;
                case 1:
                    rekenmachine.divide();
                    break;
                case 2:
                    rekenmachine.min();
                    break;
                default :
                    string pappagaay = "ik wil een koekje";
                    int naam = Int32.Parse(pappagaay);
                    break;
            }
        }
        public int plus()
        {
            int a = 2;
            int b = 6;
            Console.WriteLine(a + b);
            return (a + b);
        }
        public int divide()
        {
            int a = 2;
            int b = 6;
            Console.WriteLine(a / b);
            return (a / b);
        }
        public int min()
        {
            int a = 2;
            int b = 6;
            Console.WriteLine(a * b);
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