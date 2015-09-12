using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{    
    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentExceptionShouldBeThrownIfSchoolNameIsNull()
        {
            School school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentExceptionShouldBeThrownIfSchoolNameIsEmpty()
        {
            School school = new School(string.Empty);
        }

        [TestMethod]
        public void SchoolNameShouldBeValidWithValidNameArgument()
        {
            School school = new School("Academy");
            Assert.AreEqual(school.Name, "Academy");
        }
    }
}
