using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBankingExample
{
    internal class SavingAccount :IAccount
    {
        double savingBal;
        public SavingAccount()
        {
            savingBal = 30000;
        }
        public double Balance => savingBal;
        public double Deposit(double amount)
        {
            savingBal += amount;
            return savingBal;
        }
        public double Withdraw (double amount)
        {
            if(amount>savingBal) { Console.WriteLine("Insufficient Amount"); Console.WriteLine("Transaction Declined"); }
       
            else
            {
                if (amount > savingBal - 10000)
                {
                    Console.WriteLine("You haveto Maintain at least 10000");
                    Console.WriteLine("Transaction Declined");
                }
                else
                {
                    savingBal -= amount;
                    Console.WriteLine("Transaction Success");
                }
            }

            return savingBal;
        }
    }
}
