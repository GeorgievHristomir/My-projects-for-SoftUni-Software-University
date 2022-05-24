using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double ph = double.Parse(Console.ReadLine());
            double pm = double.Parse(Console.ReadLine());
            double pk = double.Parse(Console.ReadLine());
            double pd = double.Parse(Console.ReadLine());
            int cont1 = 0;
            int cont2 = 0;
            int cont3 = 0;
            int cont4 = 0;
            int cont5 = 0;
            for (int i = 1; i <= a; i++)
            {
                bool c1 = false;
                bool c2 = false;

                if (i % 2 == 0)
                {
                    cont1++;
                    c1 = true;
                }
                if (i % 3 == 0)
                {
                    cont2++;
                    c2 = true;
                }
                if (c1 == true && c2 == true)
                {
                    cont3++;
                    cont5++;
                }
                if (cont3 % 2 == 0 && cont3 > 0)
                {
                    cont4++;
                    cont3 = 0;
                }
                
            }
            double expenses = cont1 * ph + cont2 * pm + cont5 * pk + cont4 * pd;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
            
        }
    }
}
