namespace EmployeeStaticNonStatic
{
    public class Employee
    {
        //instance members
        private int empId;
        private string name;

        public static string companyName = "ABC Company";

        public void AcceptEmployeeInfo(int empId, string name)
        {
            this.empId = empId;
            this.name = name;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("---Employee Information---");
            Console.WriteLine("Employee ID: " + empId);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Company Name: " + companyName);
        }
    }
}
