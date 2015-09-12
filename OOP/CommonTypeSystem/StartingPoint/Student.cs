namespace StartingPoint
{
    using System;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string midName;
        private string lastName;
        private int ssn;
        private string adress;
        private string phone;
        private string mail;
        private int course;
        private University university;
        private Faculty faculty;
        private Specialty specialty;

        public Student()
        { }
        public Student(string firstName, string lastName, int ssn)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ssn = ssn;
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;
            if (student == null)
            {
                return false;
            }

            if (!Object.Equals(this.ssn, student.ssn))
            {
                return false;
            }

            if (this.firstName != student.firstName)
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return firstName.GetHashCode() ^ ssn.GetHashCode();
        }

        public override string ToString()
        {
            return (firstName + " " + lastName + " SSN: " + ssn); 
        }

        public object Clone()
        {
            Student clone = new Student();
            clone.firstName = this.firstName;
            clone.midName = this.midName;
            clone.lastName = this.lastName;
            clone.ssn = this.ssn;
            clone.adress = this.adress;
            clone.phone = this.phone;
            clone.mail = this.mail;
            clone.course = this.course;
            clone.university = this.university;
            clone.specialty = this.specialty;
            clone.faculty = this.faculty;
            return clone;
        }

        public int CompareTo(Student other)
        {
            if (this.firstName.CompareTo(other.firstName) < 0)
            {
                return -1;
            }
            else if (this.firstName.CompareTo(other.firstName) > 0)
            {
                return 1;
            }
            else
            {
                if (this.ssn < other.ssn)
                {
                    return 1;
                }
                else if (this.ssn > other.ssn)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
