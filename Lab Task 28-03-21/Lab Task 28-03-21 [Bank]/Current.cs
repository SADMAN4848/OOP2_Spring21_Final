using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_28_03_21__Bank_
{
    class CurrentAccount : Account, IBasicBankingInterface
    {
        public CurrentAccount() { }
        public CurrentAccount(string accName, string accNo, int balance) : base(accName, accNo, balance)
        {
        }
        public override void Withdraw(int amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine("Your Current Account is credited by " + amount );
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