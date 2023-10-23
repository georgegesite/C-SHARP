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

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
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
            account.Withdraw(500);
            decimal balance = account.GetBalance();
            Console.WriteLine("Account Balance: " + balance);

            Console.ReadKey();
        }
    }
}
