using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_28_03_21__Bank_
{
    public interface IBasicBankingInterface
    {
        void Deposit(int amount);
        void Withdraw(int amount);
    }
}
