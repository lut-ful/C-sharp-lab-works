using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_tutorial_d2
{
    internal class Account
    {
        public string accName { set; get; } = null;
        public double balance{ set; get; }=100.00;
        public Account(string accName,double amount)
        {
            this.accName = accName;
            this.balance = amount;
        }
        public void Deposit(double amount)
        {
            this.balance += amount;
        }
        public void Withdraw(double amount)
        {
            this.balance -= amount;
        }
    }
}
