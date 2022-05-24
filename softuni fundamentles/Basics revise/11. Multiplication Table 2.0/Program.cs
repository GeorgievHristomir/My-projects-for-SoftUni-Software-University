using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
                int num = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
            if (num2 > 10)
            {
                Console.WriteLine(num + " X " + num2 + " = " + num2 * num);
                return;
            }
                for (int i = num2; i < 11; i++)
                {
                    Console.WriteLine(num + " X " + i + " = " + num * i);
                }
            }
        }
    }


    

