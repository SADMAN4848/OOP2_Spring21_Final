using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_28_03_21__Bank_
{
    abstract class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; }
        public double Balance { get; set; }
        public Account() { }
        public Account(string accName, string accNo, double balance)
        {
            AccName = accName;
            AccNo = accNo;
            Balance = balance;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + AccName);
            Console.WriteLine("Acc No: " + AccNo);
            Console.WriteLine("Balance: " + Balance);
        }
        virtual public void Deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine("Your Account is debited by " + amount );
        }
        abstract public void Withdraw(int amount);


        


    }
}