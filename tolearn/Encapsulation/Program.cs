using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class BankAccount
    {
        private decimal _balance;
        //This is a class

        //Deposit Cash
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }
        //Withdraw Cash
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Ammount");
            }
        }

        public decimal GetBalance()
        {
            return _balance;
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount();
            account.Deposit(1000);
            account.Withdraw(1500);
            decimal balance = account.GetBalance();
            Console.WriteLine("Account Balance: " + balance);

            Console.ReadKey();
        }
    }
}
