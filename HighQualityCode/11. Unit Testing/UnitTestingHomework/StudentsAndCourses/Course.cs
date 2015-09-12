using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        private const int MaxStudents = 30;

        private string name;
        private IList<Student> students;
        

        public Course(string name, IList<Student> students)
        {
            this.Name = name;
            this.Students = students;
        }

        public Course(string name):this(name, new List<Student>())
        {
            
        }

        public string Name
        {
            get 
            {
                return this.name; 
            }

            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Course name can not be null or empty!");
                }

                this.name = value;
            }
        }

        public IList<Student> Students
        {
            get 
            {
                return new List<Student>(this.students); 
            }

            private set 
            {
                if (value.Count >= MaxStudents)
                {
                    throw new ArgumentOutOfRangeException("Students in a course should be less than " + MaxStudents + "!");
                }

                this.students = new List<Student>(value);
            }
        }

        public void JoinCourse(Student student)
        {
            if (this.Students.Count >= MaxStudents)
            {
                throw new InvalidOperationException("Students in a course should be less than " + MaxStudents + "! The course has " + MaxStudents + " already.");
            }

            this.students.Add(student);
        }

        public void LeaveCourse(Student student = null)
        {
            if (this.Students.Count == 0)
            {
                throw new InvalidOperationException("The Course is empty! There is no student to leave.");
            }

            if (student != null)
            {
                this.students.Remove(student);
            }
            else
            {
                this.students.RemoveAt(this.Students.Count - 1);
            }
        }
    }
}
