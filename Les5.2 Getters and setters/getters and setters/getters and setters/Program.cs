using System;

namespace Getters_en_Setters
{
    class Paw
    {
        public string fat = "Blubber";

        public Paw(string temp)
        {
            fat = temp;
        }
    }
    static class Dog
    {
        private static Paw Narwhal = new Paw("eenhorn?");

        public static void SetPaw(Paw Enraged)
        {
            Narwhal = Enraged;
        }
        public static Paw GiveFinn()
        {
            return Narwhal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Paw Screem = Dog.GiveFinn();
            Console.WriteLine(Screem.fat);
        }
    }
}