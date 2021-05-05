using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;
namespace UnitTestConsoleApp2
{
    [TestClass]
    public class UnitTestConsoleApp
    {
        [TestMethod]
        public void TestGetClassification()
        {
            //Arrange 
            StudentMarks studentMarks = new StudentMarks();
            //Act + Assert
            Assert.AreEqual(Classification.FAILED, studentMarks.getClassification(39));
            Assert.AreEqual(Classification.THIRD_CLASS, studentMarks.getClassification(40));
            Assert.AreEqual(Classification.THIRD_CLASS, studentMarks.getClassification(49));
            Assert.AreEqual(Classification.LOWER_SECOND_CLASS, studentMarks.getClassification(50));
            Assert.AreEqual(Classification.LOWER_SECOND_CLASS, studentMarks.getClassification(59));
            Assert.AreEqual(Classification.UPPER_SECOND_CLASS, studentMarks.getClassification(60));
            Assert.AreEqual(Classification.UPPER_SECOND_CLASS, studentMarks.getClassification(69));
            Assert.AreEqual(Classification.FIRST_CLASS, studentMarks.getClassification(70));
        }

        [TestMethod]
        public void TestCalculateStats()
        {
            //Arrange 
            StudentMarks studentMarks = new StudentMarks();
            //Act 
            studentMarks.addStudent(20); studentMarks.addStudent(79); studentMarks.addStudent(70);
            studentMarks.addStudent(54); studentMarks.addStudent(33); studentMarks.addStudent(67);
            studentMarks.addStudent(99); studentMarks.addStudent(58); studentMarks.addStudent(64);
            studentMarks.addStudent(46); studentMarks.addStudent(21); studentMarks.addStudent(69);
            studentMarks.addStudent(31); studentMarks.addStudent(78); studentMarks.addStudent(89);

            studentMarks.calculateStats();

            //Assert
            int expectedMean = 58;
            int expectedMin = 20;
            int expectedMax = 99;

            Assert.AreEqual(expectedMean, studentMarks.MeanMark);
            Assert.AreEqual(expectedMin, studentMarks.MinMark);
            Assert.AreEqual(expectedMax, studentMarks.MaxMark);
        }
        [TestMethod]
        public void TestCalculateGradeProfile()
        {
            //Arrange 
            StudentMarks studentMarks = new StudentMarks();
            //Act 
            studentMarks.addStudent(20); studentMarks.addStudent(79); studentMarks.addStudent(70);
            studentMarks.addStudent(54); studentMarks.addStudent(33); studentMarks.addStudent(67);
            studentMarks.addStudent(99); studentMarks.addStudent(58); studentMarks.addStudent(64);
            studentMarks.addStudent(46); studentMarks.addStudent(21); studentMarks.addStudent(69);
            studentMarks.addStudent(31); studentMarks.addStudent(78); studentMarks.addStudent(89);

            studentMarks.calculateGradeProfile();

            //Assert
            int expectedPercentageFailed = 26;
            int expectedPercentageThirdClass = 6;
            int expectedPercentageLowerSecondClass = 13;
            int expectedPercentageUpperSecondClass = 20;
            int expectedPercentageFirstClass = 33;

            Assert.AreEqual(expectedPercentageFailed, studentMarks.PercentageFailed);
            Assert.AreEqual(expectedPercentageThirdClass, studentMarks.PercentageThirdClass);
            Assert.AreEqual(expectedPercentageLowerSecondClass, studentMarks.PercentageLowerSecondClass);
            Assert.AreEqual(expectedPercentageUpperSecondClass, studentMarks.PercentageUpperSecondClass);
            Assert.AreEqual(expectedPercentageFirstClass, studentMarks.PercentageFirstClass);
        }
        [TestMethod]
        public void TestCalculateDistanceMilesToFeet()
        {
            //Arrange
            DistanceConverter distanceConverter = new DistanceConverter();
            distanceConverter.FromUnit = DistanceUnits.MILES;
            distanceConverter.ToUnit = DistanceUnits.FEET;
            distanceConverter.FromDistance = 1.0;

            //Act
            distanceConverter.CalculateDistance();

            //Assert
            double expectedToDistance = 5280.0;

            Assert.AreEqual(expectedToDistance, distanceConverter.ToDistance);
        }

        [TestMethod]
        public void TestCalculateDistanceFeetToMiles()
        {
            //Arrange
            DistanceConverter distanceConverter = new DistanceConverter();
            distanceConverter.FromUnit = DistanceUnits.FEET;
            distanceConverter.ToUnit = DistanceUnits.MILES;
            distanceConverter.FromDistance = 10560.0;

            //Act
            distanceConverter.CalculateDistance();

            //Assert
            double expectedToDistance = 2.0;

            Assert.AreEqual(expectedToDistance, distanceConverter.ToDistance);
        }

        [TestMethod]
        public void TestCalculateDistanceMilesToMetres()
        {
            //Arrange
            DistanceConverter distanceConverter = new DistanceConverter();
            distanceConverter.FromUnit = DistanceUnits.MILES;
            distanceConverter.ToUnit = DistanceUnits.METRES;
            distanceConverter.FromDistance = 1.0;

            //Act
            distanceConverter.CalculateDistance();

            //Assert
            double expectedToDistance = 1609.34;

            Assert.AreEqual(expectedToDistance, distanceConverter.ToDistance);
        }

        [TestMethod]
        public void TestCalculateDistanceMetresToMiles()
        {
            //Arrange
            DistanceConverter distanceConverter = new DistanceConverter();
            distanceConverter.FromUnit = DistanceUnits.METRES;
            distanceConverter.ToUnit = DistanceUnits.MILES;
            distanceConverter.FromDistance = 3218.68;

            //Act
            distanceConverter.CalculateDistance();

            //Assert
            double expectedToDistance = 2.0;

            Assert.AreEqual(expectedToDistance, distanceConverter.ToDistance);
        }

        [TestMethod]
        public void TestCalculateDistanceMetresToFeet()
        {
            //Arrange
            DistanceConverter distanceConverter = new DistanceConverter();
            distanceConverter.FromUnit = DistanceUnits.METRES;
            distanceConverter.ToUnit = DistanceUnits.FEET;
            distanceConverter.FromDistance = 2.0;

            //Act
            distanceConverter.CalculateDistance();

            //Assert
            double expectedToDistance = 6.56168;

            Assert.AreEqual(expectedToDistance, distanceConverter.ToDistance);
        }

        [TestMethod]
        public void TestCalculateDistanceFeetToMetres()
        {
            //Arrange
            DistanceConverter distanceConverter = new DistanceConverter();
            distanceConverter.FromUnit = DistanceUnits.FEET;
            distanceConverter.ToUnit = DistanceUnits.METRES;
            distanceConverter.FromDistance = 3.28084;

            //Act
            distanceConverter.CalculateDistance();

            //Assert
            double expectedToDistance = 1.0;

            Assert.AreEqual(expectedToDistance, distanceConverter.ToDistance);
        }
    }
}
