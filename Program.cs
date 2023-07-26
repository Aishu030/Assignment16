using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    internal class Program
    {
        static void Main(string[] args)
        { 
              BankAccount bAcc = new BankAccount("Aishwarya");
              Console.WriteLine($"*****Account Details as Follows*****\nAccount holder name :{bAcc.AccHolderName}\nAccount number : {bAcc.AccNo}");
              Console.WriteLine("Enter the Amount to deposit ");
              bAcc.Deposit(double.Parse(Console.ReadLine()));
              Console.WriteLine("Enter the amount to withdraw");
              bAcc.Withdraw(double.Parse(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
