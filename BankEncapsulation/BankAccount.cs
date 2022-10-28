using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
        }

        private double _balance = 0;

        public void Deposit(double amount)
        {
            _balance += amount;
            Console.WriteLine($"Deposit of ${amount} was successful. Your new balance is ${_balance}");
        }

        public void Withdrawal(double amount)
        {
            _balance -= amount;
            Console.WriteLine($"Withdrawal of ${amount} was successful. Your new balance is ${_balance}");
        }

        public void GetBalance()
        {
            Console.WriteLine($"Your current balance is ${_balance}");
        }
    
    }
}
