using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {


                string name = Console.ReadLine();
                if (name == "End")
                {
                    return;
                }
                string nameSave = name;
                double price = double.Parse(Console.ReadLine());

                double sum = 0.0;
                while (sum < price)
                {
                    name = Console.ReadLine();
                    

                    sum += double.Parse(name);


                }
                Console.WriteLine("Going to {0}!", nameSave);
            }
        }
    }
}
