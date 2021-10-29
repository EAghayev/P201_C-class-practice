using System;
using System.Collections.Generic;
using System.Text;

namespace _29102921
{
    class Human
    {
        public Human()
        {

        }
        public Human(string name)
        {
            this.Name = name;
        }

        public Human(string name,string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name;
        public string Surname;
        public byte Age;

        public string GetFullName()
        {
            return $"{this.Name} {this.Surname}";
        }

        public void ShowFullName()
        {
            Console.WriteLine($"{this.GetFullName()}");
        }
    }
}
