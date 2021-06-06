using ConsoleAppProject.App01;
using System;

namespace ConsoleApp2
{
    ///<summary>
    ///  Main program for a selection of applications.
    ///</summary> 
    public static class Program
    {
        ///<summary>
        ///  Method shows the selection of applications and allows people to choose what application to use.
        ///</summary> 
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("BNU CO453 Application Programming 2020-2021");
            Console.WriteLine();
            Console.Beep();
            DistanceConverter converter = new DistanceConverter();
            BMICalculator calculator = new BMICalculator();
            StudentMarks studentMarks = new StudentMarks();
            NetworkApp networkApp = new NetworkApp();
            while (true)
            {
                Console.WriteLine("Select a program:");
                Console.WriteLine("1. Distance Converter");
                Console.WriteLine("2. BMI Calculator");
                Console.WriteLine("3. Student Grades");
                Console.WriteLine("4. Network");
                Console.WriteLine("5. Mono Game");
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
                else if (choice == 4)
                {
                    networkApp.run();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
