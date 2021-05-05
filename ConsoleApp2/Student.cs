using System;

namespace ConsoleAppProject.App01
{
    //Class contains and displays the details of a student.
    class Student
    {
        public int studentID { get; set; }
        public Classification classification { get; set; }
        public int mark { get; set; }

        //Method shows student information.
        public void display()
        {
            ConsoleHelper.OutputText("Student ID: " + studentID + " Mark: " + mark + " Grade: " + classification);
        }
    }
    
} 
