using System;

namespace _03._Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            switch (animal)
            {
                case "crocodile":
                case "tortoise":
                case "snake":

                    Console.WriteLine("reptile");
                    break;
                case "dog":

                    Console.WriteLine("mammal");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
