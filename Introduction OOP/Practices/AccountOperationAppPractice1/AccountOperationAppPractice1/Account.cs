using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    class Account
    {
        public int accountNo;
        public string name;
        private double balance;

        public void Diposite(double amount)
        {
            this.balance = this.balance + amount;
        }

        public void Withdraw(double amount)
        {
            this.balance = this.balance - amount;
        }


        public double GetBalace()
        {
            return balance;
        }

    }
}
