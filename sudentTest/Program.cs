using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudentTest
{
    class Student
    {
        int rollno;
        string name;
        string course;
        //int paidfee;
        //int totalfee;
        //int taxreturn;
        //int payment;
        //int fg

        // static _servicetax =12.3F;


        public Student()
        {
            Console.WriteLine("Enter your rollno ");
            rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your name ");
            name = (Console.ReadLine());
            Console.WriteLine("Enter your course ");
            course = (Console.ReadLine());
            //Console.WriteLine("Enter paidfee ");
            //paidfee = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter totalfee ");
            //totalfee = int.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("rollno" + " " + "name" + " " + "course" + "  " + "totalfee" + " " + "paidfee");
        }

        //public float totalfee()
        //{
        //    return totalfee;
        //    fg =(paidfee * 12.3F) / 100 
        //}
        //public void payment()
        //{
        //    taxreturn = feepaid * servicetax

        //        fg = taxreturn  + feepaid


        //}

        static void Main(string[] args)
        {
            Student s1 = new Student();

            Console.ReadKey();
        }

    }
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //    }
    //}
}
