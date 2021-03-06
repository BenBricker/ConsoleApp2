using System;

namespace ConsoleAppProject.App01
{
    ///<summary>
    ///  The class provides a set of methods that interact with the console.
    ///  The class provides validation for information read from the console.
    ///</summary>
    public static class ConsoleHelper
    {
        ///<summary>
        /// Method displays a list of distance units.
        ///</summary>
        public static void DisplayChoices()
        {
            ///<summary>
            /// Initialises instance variables.
            ///</summary>
            // initialise instance variables
            Console.WriteLine("1. Feet" + ".\n" +
                                "2. Metres" + ".\n" +
                                "3. Miles");

            Console.WriteLine("Please enter your choice");
        }

        public static DistanceUnits SelectChoice()
        {
            string value = Console.ReadLine();
            
            while (true)
            {
                try 
                {
                    int choice = Convert.ToInt32(value);
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
        }

        ///<summary>
        ///  Method outputs a title.
        ///</summary> 
        public static void OutputTitle()
        {
            Console.WriteLine("Distance Converter (miles to feet) by Ben Bricker");
        }

        ///<summary>
        ///  Method allows someone to choose a unit to convert.
        ///</summary> 
        public static void OutputHeadingFrom()
        {
            Console.WriteLine("Select distance unit to convert from");
        }

        ///<summary>
        ///  Method allows someone to choose a unit to convert to.
        ///</summary> 
        public static void OutputHeadingTo()
        {
            Console.WriteLine("Select distance unit to convert to");
        }

        ///<summary>
        ///  Method allows the result to be output.
        ///</summary> 
        public static void OutputResult(double distF, DistanceUnits unitF,
                                        double distT, DistanceUnits unitT)
        {
            Console.Write(distF);
            Console.Write(" " + unitF + " is ");
            Console.Write(distT);
            Console.WriteLine(" " + unitT);
        }

        ///<summary>
        ///  Method uses try-catch to get the distance.
        ///</summary> 
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

        ///<summary>
        ///  Method usses a while loop and try-catch to select BMI choices.
        ///</summary> 
        public static BMIUnits SelectBMIChoice()
        {
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

        ///<summary>
        ///  Method outputs text
        ///</summary> 
        public static void OutputText(string text)
        {
            Console.WriteLine(text);
        }

        ///<summary>
        ///  Method inputs text
        ///</summary> 
        public static string InputText()
        {
            return Console.ReadLine();
        }

        ///<summary>
        ///  Method uses a while loop and try-catch to get height.
        ///</summary> 
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

        ///<summary>
        ///  Method uses a while loop and try-catch to get height.
        ///</summary> 
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
                    Console.WriteLine("Error, the inches must be entered as an integer");
                    value = Console.ReadLine();
                }
            }    
        }

        ///<summary>
        ///  Method uses a while loop and try-catch to get height.
        ///</summary> 
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

        ///<summary>
        ///  Method uses a while loop and try-catch to get weight.
        ///</summary> 
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

        ///<summary>
        ///  Method uses a while loop and try-catch to get weight.
        ///</summary> 
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

        ///<summary>
        ///  Method uses a while loop and try-catch to get weight.
        ///</summary> 
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

        ///<summary>
        ///  Method uses a while loop and try-catch to get a mark.
        ///</summary> 
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
