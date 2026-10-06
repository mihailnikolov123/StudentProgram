using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Student
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public int number;
        public string specialty;
        public int course;

        public Student(string f, string m, string l)
        {
            firstName = f;
            middleName = m;
            lastName = l;
        }

        public Student(string f, string m, string l, int n)
        {
            firstName = f;
            middleName = m;
            lastName = l;
            number = n;
        }

        public Student(string f, string m, string l, int n, string s, int c)
        {
            firstName = f;
            middleName = m;
            lastName = l;
            number = n;
            specialty = s;
            course = c;
        }

        public void Show()
        {
            Console.WriteLine("Име: " + firstName + " " + middleName + " " + lastName);
            Console.WriteLine("Факултетен номер: " + number);
            Console.WriteLine("Специалност: " + specialty);
            Console.WriteLine("Курс: " + course);
        }
    }
}

