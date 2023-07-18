using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBankingExample
{
    internal class CurretAcount :IAccount
    {
        double currentBal;
        public CurrentAccount()
        {
            currentBal = 75000;
        }

        public double Balance => currentBal;

        public double Deposit(double amount)
        {
            currentBal += amount;
            return currentBal;
        }

        public double Withdraw(double amount)
        {
            if(currentBal<amount)
            {
                Console.WriteLine("Insufficient Amount");
                Console.WriteLine("Transaction Failed");
            }
            else
            {
                currentBal -= amount;
                Console.WriteLine("Transaction Success");
            }
            return currentBal;
        }

    }
}
