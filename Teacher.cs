using System;
using System.Collections.Generic;
using System.Text;

namespace LAb1
{
     class Teacher : Human
    {
        
        private short course_students_max = 0;
        private Student[] course_students = new Student[0];
        private string group;
        public Teacher(short age, short height, short number, string name, string surname, string street, string group)
            : base(age, height, number, name, surname, street)
        {
            adress.number = number;
            adress.street = street;
            this.age = age;
            this.height = height;
            this.name = name;
            this.surname = surname;
            this.group = group;
        }
        public Student Course_students
        {
            set
            {
                if (course_students.Length != course_students_max)
                {
                    Student[] kistul = new Student[course_students.Length + 1];
                    for (short i = 0; i < course_students.Length; i++)
                    {
                        kistul[i] = course_students[i];
                    }
                    kistul[course_students.Length] = value;
                    course_students = kistul;
                }
            }
        }
        public void Get_Course_students()
        {
            for (short i = 0; i < course_students.Length; i++)
            {
                Console.WriteLine(course_students[i].Name);
                Console.WriteLine(course_students[i].Surname);


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
    }
   
}
