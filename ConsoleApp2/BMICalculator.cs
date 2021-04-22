using System;


namespace ConsoleAppProject.App01
{
    public enum BMIUnits
    {
        METRIC, IMPERIAL, NOUNIT
    }

    public class BMICalculator
    {
        private double BMI;
        public void run()
        {
            
            ConsoleHelper.OutputText("---------------\n"+
                                     "BMI Calculator \n"+
                                     "By Ben Bricker \n"+
                                     "---------------\n");
            ConsoleHelper.OutputText("1. Metric Units\n" +
                                     "2. Imperial Units");

            
            BMIUnits units = ConsoleHelper.SelectBMIChoice();

            if (units == BMIUnits.METRIC)
            {
               double height = ConsoleHelper.getHeightMetres();
               double weight = ConsoleHelper.getWeightKg();
               BMI = weight / (height * height);
            }

            else if (units == BMIUnits.IMPERIAL)
            {
                int heightFeet = ConsoleHelper.getHeightFeet() ;
                int heightInches = ConsoleHelper.getHeightInches();
                int weightStones = ConsoleHelper.getWeightStones();
                double weightPounds = ConsoleHelper.getWeightPounds();
                heightInches += (heightFeet * 12);
                weightPounds += (weightStones * 14);
                BMI = (weightPounds * 703) / (heightInches * heightInches);
            }
            else
            {
                BMI = 0.0;
            }
            if (Double.IsInfinity(BMI))
            {
                ConsoleHelper.OutputText("Entered height is zero, cannot calculate BMI");
            }
            else
            {
                weightStatus();
            }  
        }
        private void weightStatus()
        {
            string status;

            if (BMI < 18.50)
            {
                status = "Underweight";
            }
            else if (BMI < 25.0)
            {
                status = "Normal";
            }
            else if (BMI < 30.0) 
            {
                status = "Overweight";
            }
            else if (BMI < 35.0)
            {
                status = "Obese Class I";
            }
            else if (BMI < 40.0)
            {
                status = "Obese Class II";
            }
            else
            {
                status = "Obese Class III";
            }

            ConsoleHelper.OutputText("Your BMI is " + BMI + ", You are in " + status + " range!");

            ConsoleHelper.OutputText("If you are Black, Asian or other minority\n" +
                                     "ethnic groups, you have a higher risk" +

                                     "Adults 23.0 or more are at increased risk\n" +
                                     "Adults 27.5 or more are at high risk");
        }
    }
}
