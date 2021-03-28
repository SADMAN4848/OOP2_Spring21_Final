using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_28_03_21__Bank_
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Savings("Khalid Labib", "789463", 50000);
            Account a2 = new Overdraft("Ezaz Tehasy", "789465", 60000);
            Account a3 = new Savings("Mehrab Faisal", "789466", 30000);


            Person p1 = new Person("Sadman Rahman");
            p1.AddAccount(a1, a2, a3);

            a1.Withdraw(30000);
            a1.Deposit(4000);
            
            a2.Withdraw(63000);
            a2.Deposit(5000);

            p1.ShowAccontDetails();

        }
    }
}