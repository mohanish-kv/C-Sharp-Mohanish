using System;
namespace StudentStaticNonStatic
{
    public class Student
    {
        //instance members
        private int studentId;
        private string name;

        public static string schoolName = "XYZ School";

        public void AcceptStudentInfo(int studentId, string name)
        {
            this.studentId = studentId;
            this.name = name;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine("---Student Information---");
            Console.WriteLine("Student ID: " + studentId);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("School Name: " + schoolName);
        }
    }
}
