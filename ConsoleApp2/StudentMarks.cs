using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App01
{
    public enum Classification 
    {
        FIRST_CLASS, UPPER_SECOND_CLASS, LOWER_SECOND_CLASS, THIRD_CLASS, FAILED
    }
    class StudentMarks
    {
        private List<Student> students = new List<Student>();
        private int nextStudentID = 1;
        private int meanMark;
        private int minMark;
        private int maxMark;
        private int percentageFailed;
        private int percentageThirdClass;
        private int percentageLowerSecondClass;
        private int percentageUpperSecondClass;
        private int percentageFirstClass;

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
            foreach (Student aStudent in students)
            {
                aStudent.display();
            }

            ConsoleHelper.OutputText("\n Mean mark: " + meanMark + ", Lowest mark: " + minMark + ", Highest mark: " + maxMark);
            ConsoleHelper.OutputText("\n Grade Profile based on " + students.Count + " students. \n First Class Percentage: " + percentageFirstClass +
                                     "\n Upper Class Percentage: " + percentageUpperSecondClass +
                                     "\n Lower Class Percentage: " + percentageLowerSecondClass +
                                     "\n Third Class Percentage: " + percentageThirdClass +
                                     "\n Failed Percentage: " + percentageFailed);
        }    
        private Classification getClassification(int mark)
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
        private void enterStudentMarks()
        {
            while (true)
            {
                ConsoleHelper.OutputText("Enter mark for student " + nextStudentID + " from 0 to 100, -1 to quit");
                int mark = ConsoleHelper.getMark(-1,100);
                if (mark == -1)
                    break;
           
                Classification grade = getClassification(mark);
                students.Add(new Student() { studentID = nextStudentID, mark = mark, classification = grade });
                nextStudentID += 1;
            }
        }
        private void calculateStats()
        {
            int totalMarks = 0;
            minMark = 100;
            maxMark = 0;
            foreach (Student aStudent in students)
            {
                totalMarks += aStudent.mark;
                if (aStudent.mark < minMark) { minMark = aStudent.mark; }
                if (aStudent.mark > maxMark) { maxMark = aStudent.mark; }
            }
            meanMark = totalMarks / students.Count;
        }
        private void calculateGradeProfile()
        {
            int numFailed = 0;
            int numThirdClass = 0;
            int numLowerSecondClass = 0;
            int numUpperSecondClass = 0;
            int numFirstClass = 0;

            foreach (Student aStudent in students)
            {
                if (aStudent.classification == Classification.FAILED) { numFailed++; }
                if (aStudent.classification == Classification.THIRD_CLASS) { numThirdClass++; }
                if (aStudent.classification == Classification.LOWER_SECOND_CLASS) { numLowerSecondClass++; }
                if (aStudent.classification == Classification.UPPER_SECOND_CLASS) { numUpperSecondClass++; }
                if (aStudent.classification == Classification.FIRST_CLASS) { numFirstClass++; }
            }
            percentageFailed = (numFailed * 100) / students.Count;
            percentageThirdClass = (numThirdClass * 100) / students.Count;
            percentageLowerSecondClass = (numLowerSecondClass * 100) / students.Count;
            percentageUpperSecondClass = (numUpperSecondClass * 100) / students.Count;
            percentageFirstClass = (numFirstClass * 100) / students.Count;

        }
    }

}


