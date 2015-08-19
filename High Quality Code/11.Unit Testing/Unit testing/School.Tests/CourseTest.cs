namespace Schools.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MySchool;

    [TestClass]
    public class CourseTest
    {
        private const int MaximalNumberOfStudentsInCourse = 29;

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourseNameIfNullToThrowArgumentNullException()
        {
            Course myCourse = new Course(null);            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourseNameIfEmptyStringToThrowArgumentException()
        {
            Course myCourse = new Course(string.Empty);
        }

        [TestMethod]       
        public void TestCourseNameIfEqualToValidInput()
        {
            Course myCourse = new Course("abcd");
            var testCourseName = "abcd";
            Assert.AreEqual(testCourseName, myCourse.Name);
        }

        [TestMethod]
        public void TestCourseToHaveLessThan30Students()
        {
            var student = new Student("aaa", 12345);
            var myCourse = new Course("aa");
            for (int i = 0; i < 32; i++)
            {
                myCourse.AddStudent(student);
            }

            var expectedNumberOfStudentsInTheCourse = MaximalNumberOfStudentsInCourse;
            Assert.AreEqual(expectedNumberOfStudentsInTheCourse, myCourse.Students.Count);
        }

        [TestMethod]
        public void TestCourseAddStudentMethodIfStudentIsPassedToBeAdded()
        {
            var student = new Student("aaa", 12345);
            var myCourse = new Course("aa");            
            myCourse.AddStudent(student);  
            Assert.AreEqual(student.ID, myCourse.Students[0].ID);
        }

        [TestMethod]
        public void TestCourseRemoveStudentMethodIfValidStudentIsPassedToBeRemoved()
        {
            var student = new Student("aaa", 12345);
            var myCourse = new Course("aa");
            myCourse.AddStudent(student);
            myCourse.RemoveStudent(student);
            Assert.AreEqual(myCourse.Students.Count, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCourseRemoveStudentMethodIfInvalidStudentIsPassedToBeRemoved()
        {
            var validStudent = new Student("aaa", 12345);
            var invalidStudent = new Student("we", 12345);
            var myCourse = new Course("aa");
            myCourse.AddStudent(validStudent);
            myCourse.RemoveStudent(invalidStudent);            
        }
    }
}