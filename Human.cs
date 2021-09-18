using System;
using System.Collections.Generic;
using System.Text;

namespace LAb1
{
    public class Human
    {
        protected short age = 0;
        protected short height = 10;
        protected string name = "Den";
        protected string surname = "Murray";
        protected class Adress
        {
            public string street = "";
            public short number = 0;
        }
        protected Adress adress;
        public Human(short age, short height, short number, string name, string surname, string street)
        {
            adress.number = number;
            adress.street = street;
            this.age = age;
            this.height = height;
            this.name = name;
            this.surname = surname;
        }
        string Name
        {
            set { name = value; }
            get { return name; }
        }
        string Surname
        {
            set { surname = value; }
            get { return surname; }
        }
        string Street
        {
            set { adress.street = value; }
            get { return adress.street; }
        }
        short Age
        {
            set { age = value; }
            get { return age; }
        }
        short Height
        {
            set { height = value; }
            get { return height; }
        }
        short Number
        {
            set { adress.number = value; }
            get { return adress.number; }
        }
      
        
    }
}
