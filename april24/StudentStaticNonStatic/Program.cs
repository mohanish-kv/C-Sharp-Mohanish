using System;
using System.Collections.Generic;
using System.Text;

namespace StudentStaticNonStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.AcceptStudentInfo(1, "Ram");
            s1.DisplayStudentInfo();

            Student s2 = new Student();
            s2.AcceptStudentInfo(2, "Bob");
            s2.DisplayStudentInfo();
            Console.ReadKey();
        }
    }
}
