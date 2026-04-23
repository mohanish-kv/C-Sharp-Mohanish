using System;

class Employee
{
    static void AcceptEmployee(params object[] data)
    {
        int empId = 0;
        string name = "";
        double salary = 0;

        foreach (object item in data)
        {
            if (item is int)
                empId = (int)item;
            else if (item is string)
                name = (string)item;
            else if (item is double)
                salary = (double)item;
            else if (item is float)
                salary = Convert.ToDouble(item);
        }

        Console.WriteLine("Employee Id   : " + empId);
        Console.WriteLine("Employee Name : " + name);
        Console.WriteLine("Salary        : " + salary);
        Console.WriteLine("--------------------------------");
    }

    static void Main()
    {

        AcceptEmployee(1001, "Ram", 25000.0);
        AcceptEmployee("Krish", 25000.0, 1002);
        AcceptEmployee(26000.0, 1003, "John");
    }
}