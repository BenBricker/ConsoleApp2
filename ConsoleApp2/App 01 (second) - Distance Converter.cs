using System;

namespace ConsoleAppProject.App01
{
    public enum DistanceUnits
    {
        NOUNIT, FEET, METRES, MILES
    }

    public class DistanceConverter
    {
        private const double FEET_IN_METRES = 3.28084;
        private const double FEET_IN_MILES = 5280.0;
        private const double METRES_IN_MILES = 1609.34;


        private double FromDistance;
        private DistanceUnits FromUnit;
        private double ToDistance;
        private DistanceUnits ToUnit;

        public void run()
        {
            ConsoleHelper.OutputTitle();

            ConsoleHelper.OutputHeadingFrom();
            ConsoleHelper.DisplayChoices();
            FromUnit = ConsoleHelper.SelectChoice();

            ConsoleHelper.OutputHeadingTo();
            ConsoleHelper.DisplayChoices();
            ToUnit = ConsoleHelper.SelectChoice();

            FromDistance = ConsoleHelper.getDistance(FromUnit);

            CalculateDistance();

            ConsoleHelper.OutputResult(FromDistance, FromUnit, ToDistance, ToUnit);
        }

        public void CalculateDistance()
        {
            ToDistance = FromDistance;
            if (FromUnit == DistanceUnits.MILES && ToUnit == DistanceUnits.FEET)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.MILES && ToUnit == DistanceUnits.METRES)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.FEET && ToUnit == DistanceUnits.METRES)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
            else if (FromUnit == DistanceUnits.FEET && ToUnit == DistanceUnits.MILES)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.METRES && ToUnit == DistanceUnits.MILES)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.METRES && ToUnit == DistanceUnits.FEET)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }
        }


        private void OutputHeading()
        {
            Console.WriteLine("");
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("     Convert Miles to Feet    ");
            Console.WriteLine("         by Ben Bricker       ");
            Console.WriteLine(" -----------------------------\n");
            Console.WriteLine("");
        }
    }
}

/*public enum DistanceUnits
{
    NOUNIT, FEET, METRES, MILES
}

private static final float FEET_IN_METRES = (float)3.28084;
private static final float FEET_IN_MILES = (float)5280.0;
private static final float METRES_IN_MILES = (float)1609.34;


private float FromDistance;
private DistanceUnits FromUnit;
private float ToDistance;
private DistanceUnits ToUnit;

public DistanceConverter()
{
    //run();
}*/
/*blic enum DistanceUnits
{
    NOUNIT, FEET, METRES, MILES
}

private static final float FEET_IN_METRES = (float)3.28084;
private static final float FEET_IN_MILES = (float)5280.0;
private static final float METRES_IN_MILES = (float)1609.34;


private float FromDistance;
private DistanceUnits FromUnit;
private float ToDistance;
private DistanceUnits ToUnit;

public DistanceConverter()
{
    run();
}

public void run()
{
    ConsoleHelper.OutputTitle();

    ConsoleHelper.OutputHeadingFrom();
    ConsoleHelper.DisplayChoices();
    FromUnit = ConsoleHelper.SelectChoice();

    ConsoleHelper.OutputHeadingTo();
    ConsoleHelper.DisplayChoices();
    ToUnit = ConsoleHelper.SelectChoice();

    FromDistance = ConsoleHelper.getDistance(FromUnit);

    CalculateDistance();

    ConsoleHelper.OutputResult(FromDistance, FromUnit, ToDistance, ToUnit);
}

public void CalculateDistance()
{
    ToDistance = FromDistance;
    if (FromUnit == DistanceUnits.MILES && ToUnit == DistanceUnits.FEET)
    {
        ToDistance = FromDistance * FEET_IN_MILES;
    }
    else if (FromUnit == DistanceUnits.MILES && ToUnit == DistanceUnits.METRES)
    {
        ToDistance = FromDistance * METRES_IN_MILES;
    }
    else if (FromUnit == DistanceUnits.FEET && ToUnit == DistanceUnits.METRES)
    {
        ToDistance = FromDistance / FEET_IN_METRES;
    }
    else if (FromUnit == DistanceUnits.FEET && ToUnit == DistanceUnits.MILES)
    {
        ToDistance = FromDistance / FEET_IN_MILES;
    }
    else if (FromUnit == DistanceUnits.METRES && ToUnit == DistanceUnits.MILES)
    {
        ToDistance = FromDistance / METRES_IN_MILES;
    }
    else if (FromUnit == DistanceUnits.METRES && ToUnit == DistanceUnits.FEET)
    {
        ToDistance = FromDistance * FEET_IN_METRES;
    }
}

public void setFromDistance(float value)
{
    FromDistance = value;
}

public void setFromUnit(DistanceUnits value)
{
    FromUnit = value;
}

public void setToUnit(DistanceUnits value)
{
    ToUnit = value;
}

public float getToDistance()
{
    return ToDistance;
}
public static void DisplayChoices()
{
    // initialise instance variables
    System.out.println("1. Feet" + ".\n" +
                        "2. Metres" + ".\n" +
                        "3. Miles");

    System.out.println("Please enter your choice");

}


public static DistanceUnits SelectChoice()
{
    // put your code here
    Scanner scanner = new Scanner(System.in);
    DistanceUnits unit;
    int choice = scanner.nextInt();
    unit = DistanceUnits.NOUNIT;
    if (choice == 1)
    {
        unit = DistanceUnits.FEET;
    }
    else if (choice == 2)
    {
        unit = DistanceUnits.METRES;
    }
    else if (choice == 3)
    {
        unit = DistanceUnits.MILES;
    }
    System.out.println("You have selected " + unit);
    return unit;
}

public static void OutputTitle()
{
    System.out.println("Distance Converter (miles to feet) by Ben Bricker");
}

public static void OutputHeadingFrom()
{
    System.out.println("Select distance unit to convert from");
}

public static void OutputHeadingTo()
{
    System.out.println("Select distance unit to convert to");
}

public static void OutputResult(float distF, DistanceUnits unitF,
                                float distT, DistanceUnits unitT)
{
    System.out.print(distF);
    System.out.print(" " + unitF + " is ");
    System.out.print(distT);
    System.out.println(" " + unitT);
}

public static float getDistance(DistanceUnits unit)
{
    System.out.println("Enter distance in " + unit);
    Scanner scanner = new Scanner(System.in);
    float distance = scanner.nextFloat();
    return distance;
}
}
*/
