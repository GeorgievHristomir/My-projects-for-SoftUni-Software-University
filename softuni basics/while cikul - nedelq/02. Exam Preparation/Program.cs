using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string lastProblem = "";
            double sum = 0;
            int br = 0;
            int br2 = 0;
            while (name != "Enough")
            {
                lastProblem = name;
                double grade = double.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    br2++;
                    if (br2 == badGrades)
                    {
                        Console.WriteLine($"You need a break, {badGrades} poor grades.");
                        break;
                    }
                }
                sum += grade;
                br++;
                name = Console.ReadLine();
                
            }
            if (br2 != badGrades)
            {
                Console.WriteLine($"Average score: {sum / br:f2}");
                Console.WriteLine($"Number of problems: {br}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
