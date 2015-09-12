using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private const int MinIDNumber = 10000;
        private const int MaxIDNumber = 99999;
        private static int currentID = MinIDNumber;
       
        private string name;
        private int id;

        public Student(string name)
        {
            this.Name = name;
            this.Id = currentID++;
        }

        public static int CurrentID
        {
            get 
            { 
                return Student.currentID; 
            }
            set 
            {
                if (value < MinIDNumber || value > MaxIDNumber)
                {
                    throw new ArgumentOutOfRangeException("Invalid unique number range!");
                }

                Student.currentID = value; 
            }
        }
        public string Name
        {
            get 
            { 
                return this.name;
            }

            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The student name can not be null or empty!");
                }

                this.name = value; 
            }
        }        

        public int Id
        {
            get 
            { 
                return this.id; 
            }

            private set
            {
                if (value < MinIDNumber || MaxIDNumber < value)
                {
                    throw new ArgumentOutOfRangeException("Student ID must be number between " + MinIDNumber + " and " + MaxIDNumber + "!");
                }

                this.id = value;
            }
        } 


    }
}
