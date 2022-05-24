using System;

namespace _06._Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int a = m % 10;
            int b = m / 10 % 10;
            int c = m / 100;
            int d = a * 100 + b * 10 + c;
            string n = d.ToString();
            for (int i = 111; i < 999; i++)
            {
                string currentNumb = i.ToString();
                int br = 0;
                for (int k = 0; k < currentNumb.Length; k++)
                {
                    if (int.Parse(currentNumb[k].ToString()) <= int.Parse(n[k].ToString()) && int.Parse(currentNumb[k].ToString()) != 0)
                    {
                        br++;
                    }
                    if (br == 3)
                    {
                        Console.WriteLine($"{currentNumb[0]} * {currentNumb[1]} * {currentNumb[2]} = {int.Parse(currentNumb[0].ToString()) * int.Parse(currentNumb[1].ToString()) * int.Parse(currentNumb[2].ToString())};");
                    }

                }
            }
        }
    }
}
