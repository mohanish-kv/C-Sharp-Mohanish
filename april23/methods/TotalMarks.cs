using System;

class Marks
{
  public static int TotalMarks(int[] marks)
  {
    int total = 0;
    for(int i = 0; i < marks.Length; i++)
    {
      total += marks[i];
    }
    return total;
  }
  public static void Main()
  {
    int[] marks = new int[5];
    for(int i =0; i< marks.Length; i++)
    {
      Console.WriteLine("Enter marks for {0} subjects",i+1);
      marks[i] = Convert.ToInt32(Console.ReadLine());
    }
    int total = TotalMarks(marks);
    Console.WriteLine("Total marks: {0}", total);
  }
}