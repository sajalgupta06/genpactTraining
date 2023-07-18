using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBankingExample
{
    internal interface IAccount
    {

        double Deposit(double amount);
        double Withdraw(double amount);
        double  Balance { get; }  
    }
}
