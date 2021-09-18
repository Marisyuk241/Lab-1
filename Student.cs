using System;
using System.Collections.Generic;
using System.Text;

namespace LAb1
{
    class Student : Human
    {
        private string group;

        public Student(short age, short height, short number, string name, string surname, string street, string group) : base (age,height,number,name,surname,street)
        {
            adress.number = number;
            adress.street = street;
            this.age = age;
            this.height = height;
            this.name = name;
            this.surname = surname;
            this.group = group;
        }
    }
}