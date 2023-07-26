using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    public class BankAccount
    {
        int nextAccno = 10356;
        int accNo;
        string accHolderName;
        double balance;

        public BankAccount(string HolderName)
        {
            this.accNo = nextAccno++;
            this.accHolderName = HolderName;
            this.balance = 0;
        }
        public int AccNo { get { return accNo; } }
        public string AccHolderName { get {  return accHolderName; } }

        public double Balance { get { return balance; } }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount} into account {accNo}.\n\nCurrent balance: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount !!!");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount} from account {accNo}. \n\nCurrent balance: {balance}");
            }
            else
            {
                Console.WriteLine("****Invalid amount or insufficient balance****");
            }
        }
    }
}