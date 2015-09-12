using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentExceptionShouldBeThrownIfNameIsNull()
        {
            Student student = new Student(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentExceptionShouldBeThrownIfNameIsEmpty()
        {
            Student student = new Student(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentOutOfRangeExceptionShouldBeThrownIfArgumentIsInvalid()
        {
            Student.CurrentID = 1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentOutOfRangeExceptionShouldBeThrownIfIdIsGreaterThanMaxCountConstant()
        {
            int maxCount = 99999;
            for (int i = 10000; i < maxCount + 2; i++)
            {
                Student st = new Student("Student " + i);
            }
        }
      
        [TestMethod]
        public void StudentNameShouldBeValidWhenNameArgumentIsValid()
        {
            Student studentTestObj = new Student("Georgi Stoqnov");
            Assert.AreEqual(studentTestObj.Name, "Georgi Stoqnov");
        }

        [TestMethod]
        public void StudentIdShouldBeValidWhenIdIsInRange()
        {
            Student studentTestObj = new Student("Evgeni Qnev");
            Assert.AreEqual(10000, studentTestObj.Id);
        }
      

        [TestCleanup]
        public void SetUniqueIDToDefault()
        {
            Student.CurrentID = 10000;
        }

   

    }
}
