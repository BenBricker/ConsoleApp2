using System;

namespace ConsoleAppProject.App01
{
    ///<summary>
    ///  Class contains and displays the details of a student.
    ///</summary> 
    class Student
    {
        public int studentID { get; set; }
        public Classification classification { get; set; }
        public int mark { get; set; }

        ///<summary>
        ///  Method shows student information.
        ///</summary> 
        public void display()
        {
            ConsoleHelper.OutputText("Student ID: " + studentID + " Mark: " + mark + " Grade: " + classification);
        }
    }
} 
