using System;

class EmployeePayslip
{
    public static void Main()
    {
        Console.WriteLine("Enter Employee ID:");
        int empId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Employee Name:");
        string empName = Console.ReadLine();

        Console.WriteLine("Enter Basic Salary:");
        double basic = Convert.ToDouble(Console.ReadLine());

        double ta = basic * 0.10;
        double da = basic * 0.12;
        double hra = basic * 0.15;
        double pf = basic * 0.10;
        double it = basic * 0.05;

        double gross = basic + ta + da + hra;
        double net = gross - (pf + it);

        Console.WriteLine("Employee ID   : {0}", empId);
        Console.WriteLine("Employee Name : {0}", empName);
        Console.WriteLine("Basic Salary  : {0}", basic);
        Console.WriteLine("TA            : {0}", ta);
        Console.WriteLine("DA            : {0}", da);
        Console.WriteLine("HRA           : {0}", hra);
        Console.WriteLine("PF            : {0}", pf);
        Console.WriteLine("IT            : {0}", it);
        Console.WriteLine("Gross Salary  : {0}", gross);
        Console.WriteLine("Net Salary    : {0}", net);
    }
}