using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test001
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string Name) { this.Name = Name; }

        public override string ToString()
        { return " Name is Name"; }
    }

    public class Student : Person
    {
        public Student(string Name) : base(Name) { }

        public void Study()
        {
            Console.WriteLine("STUDENT IS STUDYING");
        }
    }

    public class Teacher : Person
    {
        public Teacher(string Name) : base(Name) { }

        public void Explain()
        {
            Console.WriteLine("TEACHER IS EXPLAINING");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 3;

            Person[] Persons = new Person[n];

            Console.WriteLine("Enter Three Person Name");

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Persons[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    Persons[i] = new Student(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    ((Teacher)Persons[i]).Explain();
                }
                else
                {
                    ((Student)Persons[i]).Study();
                }
            }
        }
    }
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //    }
    //}
}
}
