using System;



namespace ConsoleAppProject.App01
{
    public static class ConsoleHelper
    {
        public static void DisplayChoices()
        {
            // initialise instance variables
            Console.WriteLine("1. Feet" + ".\n" +
                                "2. Metres" + ".\n" +
                                "3. Miles");

            Console.WriteLine("Please enter your choice");

        }

        public static DistanceUnits SelectChoice()
        {
            // put your code here
            DistanceUnits unit;
            string value = Console.ReadLine();
            while (true)
            {
                try 
                {
                    int choice = Convert.ToInt32(value);
                    unit = DistanceUnits.NOUNIT;
                    if (choice == 1)
                    {
                        return DistanceUnits.FEET;
                    }
                    else if (choice == 2)
                    {
                        return DistanceUnits.METRES;
                    }
                    else if (choice == 3)
                    {
                        return DistanceUnits.MILES;
                    }
                    else
                    {
                        Console.WriteLine("Error, selection must be 1 to 3, try again");
                        value = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Error occurred, try again");
                    value = Console.ReadLine();
                }


            }
            //Console.WriteLine("You have selected " + unit);
           // return unit;
        }
        public static void OutputTitle()
        {
            Console.WriteLine("Distance Converter (miles to feet) by Ben Bricker");
        }

        public static void OutputHeadingFrom()
        {
            Console.WriteLine("Select distance unit to convert from");
        }

        public static void OutputHeadingTo()
        {
            Console.WriteLine("Select distance unit to convert to");
        }

        public static void OutputResult(double distF, DistanceUnits unitF,
                                        double distT, DistanceUnits unitT)
        {
            Console.Write(distF);
            Console.Write(" " + unitF + " is ");
            Console.Write(distT);
            Console.WriteLine(" " + unitT);
        }

        public static double getDistance(DistanceUnits unit)
        {
            Console.WriteLine("Enter distance in " + unit);
            string value = Console.ReadLine();
            while (true)
            {
                try
                {
                    double distance = Convert.ToDouble(value);
                    return distance;
                }
                catch
                {
                    Console.WriteLine("Error occurred, try again");
                    value = Console.ReadLine();
                }

            }


        }

        public static BMIUnits SelectBMIChoice()
        {
            // put your code here
            string value = Console.ReadLine();
            
            while (true)
            {
                try
                {
                    int choice = Convert.ToInt32(value);
                    if (choice == 1)
                    {
                        return BMIUnits.METRIC; 
                    }
                    else if (choice == 2)
                    {
                        return BMIUnits.IMPERIAL;
                    }
                    else
                    {
                        Console.WriteLine("Error, incorrect unit selected");
                        value = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Error, the choice must be entered as an integer");
                    value = Console.ReadLine();
                }
            }
        }
        public static void OutputText(string text)
        {
            Console.WriteLine(text);
        }
        public static int getHeightFeet()
        {
            Console.WriteLine("Enter your height in feet > ");
            string value = Console.ReadLine();
            while (true)
            {
                try
                {
                    int feet = Convert.ToInt32(value);
                    if (feet >= 0)
                    {
                        return feet;
                    }
                    else
                    {
                        Console.WriteLine("Error, the height cannot be negative");
                        value = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Error, the feet must be entered as an integer");
                    value = Console.ReadLine();
                }
            }    
        }
        public static int getHeightInches()
        {
            Console.WriteLine("Enter your height in inches > ");
            string value = Console.ReadLine();
            while (true)
            {
                try
                {
                    int inches = Convert.ToInt32(value);
                    if (inches >= 0)
                    {
                        return inches;
                    }
                    else
                    {
                        Console.WriteLine("Error, the height cannot be negative");
                        value = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Error, the feet must be entered as an integer");
                    value = Console.ReadLine();
                }
            }    
        }
        public static double getHeightMetres()
        {
            Console.WriteLine("Enter your height in metres > ");
            string value = Console.ReadLine();
            while (true)
            {
                try
                {
                    double metres = Convert.ToDouble(value);
                    if (metres >= 0.0)
                    {
                        return metres;
                    }
                    else
                    {
                        Console.WriteLine("Error, the height cannot be negative");
                        value = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Error, the height cannot have letters");
                    value = Console.ReadLine();
                }
            }          
        }
        public static int getWeightStones()
        {
            Console.WriteLine("Enter your weight in stones > ");
            string value = Console.ReadLine();
            while (true)
            {
                try
                {
                    int stones = Convert.ToInt32(value);
                    if (stones >= 0)
                    {
                        return stones;
                    }
                    else
                    {
                        Console.WriteLine("Error, the weight cannot be negative");
                        value = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Error, the stones must be entered as an integer");
                    value = Console.ReadLine();
                }
            }
        }
        public static double getWeightPounds()
        {
            Console.WriteLine("Enter your weight in pounds > ");
            string value = Console.ReadLine();
            while (true)
            {
                try
                {
                    double pounds = Convert.ToDouble(value);
                    if (pounds >= 0.0)
                    {
                        return pounds;
                    }
                    else
                    {
                        Console.WriteLine("Error, the weight cannot be negative");
                        value = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Error, the weight cannot have letters");
                    value = Console.ReadLine();
                }
            }
            
            
        }
        public static double getWeightKg()
        {
            Console.WriteLine("Enter your weight in Kg > ");
            string value = Console.ReadLine();
            while (true)
            {
                try
                {
                    double kg = Convert.ToDouble(value);
                    if (kg >= 0.0)
                    {
                        return kg;
                    }
                    else
                    {
                        Console.WriteLine("Error, the weight cannot be negative");
                        value = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Error, the weight cannot have letters");
                    value = Console.ReadLine();
                }
            }        
        }
        public static int getMark(int minMark, int maxMark)
        {
            string value = Console.ReadLine();
            
            while (true)
            {
                try
                {
                    int mark = Convert.ToInt32(value);
                    if (mark >= minMark & mark <= maxMark )
                    {
                        return mark;
                    }
                    else
                    {
                        Console.WriteLine("Error, value must be between " + minMark + " and " + maxMark);
                        value = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Error, must enter an integer");
                    value = Console.ReadLine();
                }
            }
        }

    }
}
