using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        private string name;
        private IList<Course> courses;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
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
                    throw new ArgumentException("The school name can not be null or empty");
                }

                this.name = value; 
            }
        }
       
        public IList<Course> Courses
        {
            get 
            { 
                return new List<Course>(this.courses); 
            }          
        }
    }
}
