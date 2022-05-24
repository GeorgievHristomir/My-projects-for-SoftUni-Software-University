using System;

namespace _5._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string rightPass = "";
            int count = 0;
            for (int i = username.Length-1; i >= 0; i--)
            {
                rightPass += username[i];
            }
            while (true)
            {
                string password = Console.ReadLine();
                if (password == rightPass)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                    
                }
            }
        }
    }
}
