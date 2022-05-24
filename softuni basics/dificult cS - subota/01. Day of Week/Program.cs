using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string b = "";

            switch(a)
            {
                case 1:
                    b = "Monday";
                    break;
                case 2:
                    b = "Tuesday";
                    break;
                case 3:
                    b = "Wednesday";
                    break;
                case 4:
                    b = "Thursday";
                    break;
                case 5:
                    b = "Friday";
                    break;
                case 6:
                    b = "Saturday";
                    break;
                case 7:
                    b = "Sunday";
                    break;
                default:
                    Console.WriteLine("Error");
                    break;


            }
            if (a >=1 && a<=7)
                Console.WriteLine(b);

        }
    }
}
