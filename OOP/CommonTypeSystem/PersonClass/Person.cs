namespace PersonClass
{
    using System;

    public class Person
    {
        private string name;
        private int? age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; } 
        }
        public int? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public override string ToString()
        {
            if (age != null)
            {
                return String.Format("{0} is {1} years old.", this.name, this.age);
            }

            return String.Format("{0}, dont want to say years!", this.name);
        }
    }
}
