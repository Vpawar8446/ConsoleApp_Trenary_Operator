using System;

namespace ConsoleApp_Trenary_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 10000, withdrawal;
            string cust_name;
            Console.Write("Enter the customer name: ");
            cust_name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Withdrawal Amount: ");
            withdrawal = Convert.ToInt32(Console.ReadLine());
            balance = withdrawal > balance ? balance : balance - withdrawal;
            Console.WriteLine("Cusomer name: " + cust_name);
            Console.Write("Remaining Balance: " + balance);
        }
           
    }
}
