using System;

namespace ConsoleAppProject.App01
{
    class Student
    {
        public int studentID { get; set; }
        public Classification classification { get; set; }
        public int mark { get; set; }

       /* public void setID(int value)
        {
            studentID = value;
        }
        public void setClassification(Classification value)
        {
            classification = value;
        }
        public void setMark(int value)
        {
            mark = value;
        }
        public int getID()
        {
            return studentID;
        }
        public Classification getClassification()
        {
            return classification;
        }
        public int getMark()
        {
            return mark;
        }*/
        public void display()
        {
            ConsoleHelper.OutputText("Student ID: " + studentID + " Mark: " + mark + " Grade: " + classification);
        }
    }
    
} 
