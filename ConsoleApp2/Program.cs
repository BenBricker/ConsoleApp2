using ConsoleAppProject.App01;
using System;

namespace ConsoleApp2
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("BNU CO453 Application Programming 2020-2021");
            Console.WriteLine();
            Console.Beep();
            DistanceConverter converter = new DistanceConverter();
            BMICalculator calculator = new BMICalculator();
            StudentMarks studentMarks = new StudentMarks();
            while (true)
            {
                Console.WriteLine("Select a program:");
                Console.WriteLine("1. istance Converter");
                Console.WriteLine("2. BMI Calculator");
                Console.WriteLine("3. Student Grades");
                Console.WriteLine("0. Quit");
                string value = Console.ReadLine();
                int choice = Convert.ToInt32(value);
                if (choice == 1)
                {
                    converter.run();
                }
                else if (choice == 2)
                {
                    calculator.run();
                }
                else if (choice == 3)
                {
                    studentMarks.run();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
