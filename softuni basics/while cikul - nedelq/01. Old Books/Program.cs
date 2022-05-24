using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            int br = 0;
            string findBook = Console.ReadLine();
            while (findBook != favBook )
            {
                if (findBook == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {br} books.");
                    break;
                }
                findBook = Console.ReadLine();
                br++;
            }
            if (findBook == favBook)
            {
                Console.WriteLine($"You checked {br} books and found it.");
            }
        }
    }
}
