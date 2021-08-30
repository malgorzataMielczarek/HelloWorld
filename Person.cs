using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Person
    {
        private string name;
        private string surname;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

        public Person(string name = "Jan", string surname = "Kowalski")
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}
