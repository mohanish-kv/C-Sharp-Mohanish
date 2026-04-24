using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeStaticNonStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.AcceptEmployeeInfo(1, "Ram");
            e1.DisplayEmployeeInfo();

            Employee e2 = new Employee();
            e2.AcceptEmployeeInfo(2, "Bob");
            e2.DisplayEmployeeInfo();
            Console.ReadKey();
        }
    }
}
