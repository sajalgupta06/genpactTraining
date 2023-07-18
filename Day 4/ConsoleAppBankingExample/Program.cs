using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBankingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingAccount savingAccount = new SavingAccount();
            Console.WriteLine("Choose Operation\n 1.Balance\n 2.Deposite\n 3.Withdrwa");

            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                default:
                    {
                        Console.WriteLine("Invalid operation");
                        return;
                    }

                case 1:
                    {
                        Console.WriteLine("Balance is : \t" + savingAccount.Balance);
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Enter Aount to deposite");
                        double amount= double.Parse(Console.ReadLine());
                        Console.WriteLine("Balance after Transaction is \t" + savingAccount.Deposit(amount);
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("Enter Amount to withdraw");
                        double amount = double.Parse(Console.ReadLine());
                        Console.WriteLine("Balance after Transaction is : \t" + savingAccount.Withdraw(amount);
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
