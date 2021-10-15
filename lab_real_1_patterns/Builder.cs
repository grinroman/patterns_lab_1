using System;
using System.Collections.Generic;
using System.Text;

namespace lab_real_1_patterns
{
    class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Surname { get; set; }
    }

    interface IPersonBuilder
    {
        IPersonBuilder SetName(string name);
        IPersonBuilder SetAge(string age);
        IPersonBuilder SetSurname(string surname);

        Person Build();
    }

    class PersonBiulder : IPersonBuilder
    {
        Person person;
        public PersonBiulder() => person = new Person();

        public Person Build() => person;

        public IPersonBuilder SetName (string name)
        {
            person.Name = name;
            return this;
        }

        public IPersonBuilder SetAge(string age)
        {
            person.Age = age;
            return this;
        }

        public IPersonBuilder SetSurname(string surname)
        {
            person.Surname = surname;
            return this;
        }
    }


}
