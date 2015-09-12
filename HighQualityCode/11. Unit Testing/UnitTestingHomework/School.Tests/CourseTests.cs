using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace School.Tests
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentExceptionShouldBeThrownIfCourseNameIsNull()
        {
            Course testCourse = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentExceptionShouldBeThrownIfCourseNameIsEmpty()
        {
            Course testCourse = new Course(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentOutOfRangeExceptionShouldBeThrownWhenCreateCourseWithInvalidCountOfStudents()
        {
            List<Student> studentsList = new List<Student>();

            for (var i = 0; i < 31; i++)
            {
                studentsList.Add(new Student("Student " + i));
            }
            Course testCourse = new Course("KPK",studentsList);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidOperationExceptionShoulBeThrownWhenAddStudentToFullLimitCourse()
        {
            Course course = new Course("KPK");

            for (int i = 0; i < 31; i++)
            {
                course.JoinCourse(new Student("Student " + i));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidOperationExceptionShoulBeThrownWhenStudentLeaveFromCourseWhichIsEmpty()
        {
            Course course = new Course("KPK");           
            course.LeaveCourse();       
        }

        [TestMethod]        
        public void CourseNameShouldBeValidWithValidNameArgument()
        {
            Course course = new Course("KPK");
            Assert.AreEqual(course.Name, "KPK");
        }

        [TestMethod]
        public void StudentListInCourseShouldBeUpdatedWhenJoinStudent()
        {
            Course course = new Course("KPK");
            course.JoinCourse(new Student("Ivan"));
            Assert.AreEqual(1, course.Students.Count);
        }

        [TestMethod]
        public void StudentShouldNotBeInListWhenLeaveCourse()
        {
            Course course = new Course("KPK");
            Student studentIvan = new Student("Ivan");

            course.JoinCourse(studentIvan);
            Assert.AreEqual(true, course.Students.Contains(studentIvan));
            course.LeaveCourse(studentIvan);
            Assert.AreEqual(false, course.Students.Contains(studentIvan));
        }

        [TestMethod]
        public void LastStudentInStudentListShouldLeaveWhenNoStudentArgumentIsPassed()
        {
            Course course = new Course("KPK");
            Student studentIvan = new Student("Ivan");
            Student studentZdravko = new Student("Zdravko");
            Student studentEvelin = new Student("Evelin");

            course.JoinCourse(studentIvan);
            course.JoinCourse(studentZdravko);
            course.JoinCourse(studentEvelin);

            Assert.AreEqual(true, course.Students[course.Students.Count - 1] == studentEvelin);
            course.LeaveCourse();
            Assert.AreEqual(false, course.Students.Contains(studentEvelin));
        }



    }
}
