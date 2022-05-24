using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int br = 0;
            int br2 = 0;
            while(money< moneyNeeded)
            {
                br++;
                string action = Console.ReadLine();
                double SorS = double.Parse(Console.ReadLine());
                if (action == "spend")
                {
                    br2++;
                    if (br2 == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(br);
                        break;
                    }
                    if (SorS > money)
                    {
                        money = 0;
                    }
                    else
                        money = money - SorS;
                }
                else if (action == "save")
                {
                    br2 = 0;
                    money += SorS;
                }

            }
            if (br2 != 5)
            {
                Console.WriteLine($"You saved the money for {br} days.");
            }
        }
    }
}
