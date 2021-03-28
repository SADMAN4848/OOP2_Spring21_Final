using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_28_03_21__Bank_
{
    class Savings : Account, IBasicBankingInterface
    {
        public Savings() { }
        public Savings(string accName, string accNo, int balance) : base(accName, accNo, balance)
        {
        }
        public override void Withdraw(int amount)
        {
            if (Balance - amount >= (Balance * 20) / 100)
            {
                Balance -= amount;
                Console.WriteLine("Your Savings account is credited by "+amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
        public override void Deposit(int amount)
        {
            base.Deposit(amount);
        }

    }
}