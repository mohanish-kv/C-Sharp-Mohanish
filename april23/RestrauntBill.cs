using System;

class BillCalculation
{
    static void CalculateGST(double billAmount, out double sgst, out double cgst)
    {
        sgst = billAmount * 0.05; 
        cgst = billAmount * 0.03; 
    }

    static void Main()
    {
        Console.WriteLine("Enter Bill Amount:");
        double billAmount = Convert.ToDouble(Console.ReadLine());
        double sgst, cgst;
        CalculateGST(billAmount, out sgst, out cgst);
        double totalAmount = billAmount + sgst + cgst;
        Console.WriteLine("Bill Amount : " + billAmount + "\nSGST (5%)   : " + sgst + "\nCGST (3%)   : " + cgst + "\nTotal Amount: " + totalAmount);

}
}
