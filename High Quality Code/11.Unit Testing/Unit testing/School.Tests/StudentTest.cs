namespace Schools.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MySchool;

    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void TestStudentNameToBeEqualToTestString()
        {
            var student = new Student("Aaaa", 11111);
            var expectedName = "Aaaa";
            Assert.AreEqual(expectedName, student.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentNameEqualToNullToThrowArgumentException()
        {
            var student = new Student(null, 1111);          
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentBlankNameToThrowArgumentException()
        {
            var student = new Student(string.Empty, 11111);            
        }      

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentIDEqualTo9999ToThrowArgumentException()
        {
            var student = new Student("aaa", 9999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentIDEqualTo100000ToThrowArgumentException()
        {
            var student = new Student("aaa", 100000);
        }

        [TestMethod]
        public void TestCorrectIDtoBeRecordedAsID()
        {
            var student = new Student("aaa", 12345);
            var expectedID = 12345;
            Assert.AreEqual(expectedID, student.ID);
        }

        [TestMethod]
        public void TestCorrectID99999toBeRecordedAsID()
        {
            int idNumber = 99999;
            var student = new Student("aaa", idNumber);           
            Assert.IsTrue(idNumber >= 10000 && idNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentIDIntMaxValueToThrowArgumentException()
        {
            var id = int.MaxValue;
            var student = new Student("aaa", id);     
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentIDIntMinValueToThrowArgumentException()
        {
            var id = int.MinValue;
            var student = new Student("aaa", id);
        }       
    }
}
