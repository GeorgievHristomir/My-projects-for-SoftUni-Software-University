﻿using System;

namespace _08.Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":

                case "Friday":
                    Console.WriteLine("12");
                    break;
                case "Wednesday":
                case "Thursday":
                    Console.WriteLine("14");
                    break;
                default:
                    Console.WriteLine("16");
                    break;
            }
        }
    }
}
