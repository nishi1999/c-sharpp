using System;

namespace Bank
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            Account a1 = new Fixed("NISHI", "1", 10000, 2020, 5);
            Account a2 = new Savings("SAkIB", "2", 50000, 10);
            Account a3 = new SpecialSavings("NIDHI", "3", 20000, 5);
            Account a4 = new Overdraft("AKASH", "4", 150000, 20000);


            a1.Withdraw(500);
            a2.Withdraw(500);
            a3.Withdraw(500);
            a4.Withdraw(500);

            

            a1.Withdraw(5000);
            a2.Withdraw(40000);
            a3.Withdraw(6000);
            a4.Withdraw(10000);

        }
    }
}