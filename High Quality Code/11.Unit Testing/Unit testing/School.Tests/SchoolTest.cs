namespace Schools.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MySchool;

    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSchoolNameIfNullToThrowArgumentException()
        {
            School mySchool = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSchoolNameIfEmptyStringToThrowArgumentException()
        {
            School mySchool = new School(string.Empty);
        }

        [TestMethod]
        public void TestSchoolNameIfEqualToValidInput()
        {
            var mySchool = new School("abcd");
            var testSchoolName = "abcd";
            Assert.AreEqual(testSchoolName, mySchool.Name);
        }

         [TestMethod]
        public void TestChangingSchoolNameIfEqualToValidInput()
        {
            School mySchool = new School("abcd");
            string testSchoolName = "testName";
            mySchool.Name = testSchoolName;
            Assert.AreEqual(testSchoolName, mySchool.Name);
        }

         [TestMethod]
         public void TestGettingSchoolNameIfEqualToValidInput()
         {
             string testSchoolName = "abcd";
             School mySchool = new School(testSchoolName);
             string gottenSchoolName = mySchool.Name;
             Assert.AreEqual(testSchoolName, gottenSchoolName);
         }

        [TestMethod]
         public void TestSchoolAddCourseMethodToAddCourses()
        {            
            var myCourse = new Course("aa");
            var myAnotherCourse = new Course("aa");
            var mySchool = new School("zz");
            mySchool.AddCourse(myCourse);
            mySchool.AddCourse(myAnotherCourse);
            int courseCount = 2;
            Assert.AreEqual(courseCount, mySchool.Courses.Count);        
        }
    }
}
