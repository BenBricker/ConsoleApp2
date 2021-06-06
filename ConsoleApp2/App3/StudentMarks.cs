using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App01
{
    ///<summary>
    /// Enum contains differents classifications.
    ///</summary>
    public enum Classification 
    {
        FIRST_CLASS, UPPER_SECOND_CLASS, LOWER_SECOND_CLASS, THIRD_CLASS, FAILED
    }

    ///<summary>
    /// Class maintains data for a list of students and their marks.
    /// Class calculates statistics based on student marks.
    ///</summary>
    public class StudentMarks
    {
        private List<Student> Students = new List<Student>();
        private int nextStudentID = 1;
        public int MeanMark { get; set; }
        public int MinMark { get; set; }
        public int MaxMark { get; set; }
        public int PercentageFailed { get; set; }
        public int PercentageThirdClass { get; set; }
        public int PercentageLowerSecondClass { get; set; }
        public int PercentageUpperSecondClass { get; set; }
        public int PercentageFirstClass { get; set; }

        ///<summary>
        /// Method method calls methods to run student marks.
        ///</summary>
        public void run()
        {
            ConsoleHelper.OutputText("---------------\n" +
                                     "Student Marks \n" +
                                     "By Ben Bricker \n" +
                                     "---------------\n");
            enterStudentMarks();
            calculateStats();
            calculateGradeProfile();
           
            ConsoleHelper.OutputText("Here is a list of the student marks");
            foreach (Student aStudent in Students)
            {
                aStudent.display();
            }

            ConsoleHelper.OutputText("\n Mean mark: " + MeanMark + ", Lowest mark: " + MinMark + ", Highest mark: " + MaxMark);
            ConsoleHelper.OutputText("\n Grade Profile based on " + Students.Count + " Students. \n First Class Percentage: " + PercentageFirstClass +
                                     "\n Upper Class Percentage: " + PercentageUpperSecondClass +
                                     "\n Lower Class Percentage: " + PercentageLowerSecondClass +
                                     "\n Third Class Percentage: " + PercentageThirdClass +
                                     "\n Failed Percentage: " + PercentageFailed);
        }

        ///<summary>
        /// Method uses statements to get the classification based on a mark.
        ///</summary>
        public Classification getClassification(int mark)
        {
            if (mark < 40)
            {
                return Classification.FAILED;
            }
            if (mark < 50)
            {
                return Classification.THIRD_CLASS;
            }
            if (mark < 60)
            {
                return Classification.LOWER_SECOND_CLASS;
            }
            if (mark < 70)
            {
                return Classification.UPPER_SECOND_CLASS;
            }
            return Classification.FIRST_CLASS;
        }

        ///<summary>
        /// Method allows student marks to be entered.
        ///</summary>
        private void enterStudentMarks()
        {
            while (true)
            {
                ConsoleHelper.OutputText("Enter mark for student " + nextStudentID + " from 0 to 100, -1 to quit");
                int mark = ConsoleHelper.getMark(-1,100);
                if (mark == -1)
                    break;

                addStudent(mark);
            }
        }

        ///<summary>
        /// Method calculates total marks, minimum mark, maximum mark and mean mark.
        ///</summary>
        public void calculateStats()
        {
            int totalMarks = 0;
            MinMark = 100;
            MaxMark = 0;
            foreach (Student aStudent in Students)
            {
                totalMarks += aStudent.mark;
                if (aStudent.mark < MinMark) { MinMark = aStudent.mark; }
                if (aStudent.mark > MaxMark) { MaxMark = aStudent.mark; }
            }
            MeanMark = totalMarks / Students.Count;
        }

        ///<summary>
        /// Method shows the percentages of students in different classification.
        ///</summary>
        public void calculateGradeProfile()
        {
            int numFailed = 0;
            int numThirdClass = 0;
            int numLowerSecondClass = 0;
            int numUpperSecondClass = 0;
            int numFirstClass = 0;

            foreach (Student aStudent in Students)
            {
                if (aStudent.classification == Classification.FAILED) { numFailed++; }
                if (aStudent.classification == Classification.THIRD_CLASS) { numThirdClass++; }
                if (aStudent.classification == Classification.LOWER_SECOND_CLASS) { numLowerSecondClass++; }
                if (aStudent.classification == Classification.UPPER_SECOND_CLASS) { numUpperSecondClass++; }
                if (aStudent.classification == Classification.FIRST_CLASS) { numFirstClass++; }
            }

            PercentageFailed = (numFailed * 100) / Students.Count;
            PercentageThirdClass = (numThirdClass * 100) / Students.Count;
            PercentageLowerSecondClass = (numLowerSecondClass * 100) / Students.Count;
            PercentageUpperSecondClass = (numUpperSecondClass * 100) / Students.Count;
            PercentageFirstClass = (numFirstClass * 100) / Students.Count;
        }

        ///<summary>
        /// Method allows students to be added to the list.
        ///</summary>
        public void addStudent(int mark)
        {
            Classification grade = getClassification(mark);
            Students.Add(new Student() { studentID = nextStudentID, mark = mark, classification = grade });
            nextStudentID += 1;
        }
    }

}


