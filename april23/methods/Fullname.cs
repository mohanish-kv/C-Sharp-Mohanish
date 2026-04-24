using System;
class Fullname
{
  public static void DisplayFullName(string firstName, string middleName, string lastName)
  {
    Console.WriteLine("Full Name: " + firstName + " " + middleName + " " + lastName);
  }
  public static void Main()
  {
    Console.WriteLine("Enter your first name:");
    string firstName = Console.ReadLine();
    Console.WriteLine("Enter your middle name:");
    string middleName = Console.ReadLine();
    Console.WriteLine("Enter your last name:");
    string lastName = Console.ReadLine();
    DisplayFullName(firstName, middleName, lastName);
   
  }
}