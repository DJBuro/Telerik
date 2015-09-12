namespace Homework
{
    using System;

    public class People
    {
        private enum Gender
        {
            Man,
            Woman
        }

        public void MakePerson(int uniquePersonNumber)
        {
            Person person = new Person();
            person.Age = uniquePersonNumber;
            if (uniquePersonNumber % 2 == 0)
            {
                person.Name = "Батката";
                person.Gender = Gender.Man;
            }
            else
            {
                person.Name = "Мацето";
                person.Gender = Gender.Woman;
            }
        }

        private class Person
        {
            public Gender Gender { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}
