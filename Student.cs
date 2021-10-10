using System;
using System.Collections.Generic;
using System.Text;

namespace LAb1
{
    class Student : Human
    {
        private short average_score = 0;
        private string group;

        Random rand = new Random();
        short[] arr = new short[6];
        public Student(short age, short height, short number, string name, string surname, string street, string group)
            : base(age, height, number, name, surname, street)
        {
            adress.number = number;
            adress.street = street;
            this.age = age;
            this.height = height;
            this.name = name;
            this.surname = surname;
            this.group = group;

            for (short i = 0; i < 5; i++)
            { 
                arr[i] = Convert.ToInt16(rand.Next(1, 6));
            }
        }
        public short Age
        {
            set { age = value; }
            get { return age; }
        }

        public short Height_cen
        {
            set { height = value; }
            get { return height; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Surname
        {
            set { surname = value; }
            get { return surname; }
        }

        public string Group
        {
            set { group = value; }
            get { return group; }
        }
        public int Average_score
        {
            get
            {
                for (short i = 0; i < arr.Length; i++)
                { 
                    average_score += arr[i];
                }
                return average_score / arr.Length;
            }
        }

        public void Get_student_type()
        {
            switch (Average_score)
            {
                case 3:
                    Console.WriteLine("C grade");
                    break;
                case 4:
                    Console.WriteLine("B grade");
                    break;
                case 5:
                    Console.WriteLine("A grade");
                    break;
                default:
                    Console.WriteLine("F grade");
                    break;
            }
        }
    }
}
