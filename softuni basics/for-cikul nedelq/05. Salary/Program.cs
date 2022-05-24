using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {



                string tab = Console.ReadLine();
                switch (tab)
                {
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }


            }
            if (salary > 0)
                Console.WriteLine(salary);

        }
    }
}
