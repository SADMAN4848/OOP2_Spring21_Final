using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_28_03_21__Bank_
{
    class Overdraft : Account, IBasicBankingInterface
    {
        public Overdraft() { }
        public Overdraft(string accName, string accNo, int balance) : base(accName, accNo, balance)
        {
        }
        public override void Withdraw(int amount)
        {
            if (Balance >= amount || amount <= Balance + 5000)
            {
                Balance -= amount;
                Console.WriteLine("Your Overdraft account is credited by "+ amount);
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