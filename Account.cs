using System;
using System.Collections.Generic;
using System.Text;

namespace th4
{
    class Account
    {
        private string accName = "Nishi";
        private string acid = "19-40374-1";
        private int balance = 0;

        public string AccName
        {
            get { return accName; }
            
        }
        public string Acid
        {
            get { return acid; }
             }
        }

        public int Balance
        {
            get { return balance; }
            
        }

        public void Deposit(int amount)
        {
            balance += amount;
        }
        public void WithDraw(int amount)
        {
            balance -= amount;
        }
    }
}
