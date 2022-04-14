using System;

namespace Overerving
{
    class Animal
    {
        public void feed()
        {
            Console.WriteLine("nomnom");
        }
    }
    class horse : Animal
    {
        public string ras = "shetland";
    }
    class horsenom
    {
        static void Main(string[] args)
        {
            horse myanimal = new horse();
            myanimal.feed();
        }
            
    }
}