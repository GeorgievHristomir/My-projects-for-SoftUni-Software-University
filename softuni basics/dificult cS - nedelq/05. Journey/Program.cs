using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double spentMoney = 0;
            string holiday = "";
            string destination = "";

            switch (season)
            {
                case "summer":
                    if (budjet > 1000)
                    {
                        spentMoney = 0.9 * budjet;
                        holiday = "Hotel";
                        destination = "Europe";
                    }
                    else if (budjet > 100)
                    {
                        spentMoney = 0.4 * budjet;
                        holiday = "Camp";
                        destination = "Balkans";
                    }
                    else if (budjet <= 100)
                    {
                        spentMoney = 0.3 * budjet;
                        holiday = "Camp";
                        destination = "Bulgaria";
                    }
                    break;
                case "winter":
                    if (budjet > 1000)
                    {
                        spentMoney = 0.9 * budjet;
                        holiday = "Hotel";
                        destination = "Europe";
                    }
                    else if (budjet > 100)
                    {
                        spentMoney = 0.8 * budjet;
                        holiday = "Hotel";
                        destination = "Balkans";
                    }
                    else if (budjet <= 100)
                    {
                        spentMoney = 0.7 * budjet;
                        holiday = "Hotel";
                        destination = "Bulgaria";
                    }
                    break;

                    

            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holiday} - {spentMoney:f2}");
        }
    }
}
