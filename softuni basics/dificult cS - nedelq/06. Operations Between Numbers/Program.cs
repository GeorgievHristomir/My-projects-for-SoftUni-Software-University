using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double Result = 0;

            switch (operation)
            {
                case '+':
                    Result = num1 + num2;
                    if (Result % 2 ==0)
                        Console.WriteLine($"{num1} + {num2} = {Result} - even");
                    else
                        Console.WriteLine($"{num1} + {num2} = {Result} - odd");
                    break;
                case '-':
                    Result = num1 - num2;
                    if (Result % 2 == 0)
                        Console.WriteLine($"{num1} - {num2} = {Result} - even");
                    else
                        Console.WriteLine($"{num1} - {num2} = {Result} - odd");
                    break;
                case '*':
                    Result = num1 * num2;
                    if (Result % 2 == 0)
                        Console.WriteLine($"{num1} * {num2} = {Result} - even");
                    else
                        Console.WriteLine($"{num1} * {num2} = {Result} - odd");
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        Result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {Result:f2}");
                    }

                    else
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    break;
                case '%':
                    if (num2 == 0)
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    else
                    {
                        Result = num1 % num2;
                        Console.WriteLine($"{num1} % {num2} = {Result}");

                    }
                    
                    break;
                


            }
        }
    }
}
