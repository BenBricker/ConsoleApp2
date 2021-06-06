using System;

namespace ConsoleAppProject.App01
{
    ///<summary>
    /// Enum contains different units.
    ///</summary>
    public enum DistanceUnits
    {
        NOUNIT, FEET, METRES, MILES
    }

    ///<summary>
    /// Class converts distances between different units.
    ///</summary>
    public class DistanceConverter
    {
        public const double FEET_IN_METRES = 3.28084;
        public const double FEET_IN_MILES = 5280.0;
        public const double METRES_IN_MILES = 1609.34;

        public double FromDistance;
        public DistanceUnits FromUnit;
        public double ToDistance;
        public DistanceUnits ToUnit;

        ///<summary>
        /// Method calls methods to run the distance converter.
        ///</summary>
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

        ///<summary>
        /// Method uses statements to calculate distances.
        ///</summary>
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

        ///<summary>
        /// Method outputs heading using print statements.
        ///</summary>
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
