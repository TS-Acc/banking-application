using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_application
{
    internal class Account
    {

        public string AccountId { get; set; } = string.Empty; // unique id for the account
        public decimal Balance { get; set; } = 0;
        public string Description { get; set; } = string.Empty;

        public bool Deposit(decimal Amount)
        {
            if (Amount <= 0)
            {
                Console.WriteLine($"Amount cannot be zero or negative.");
                return false; // you can put return on a void method as long as it's not returning
                        // anything. this will not let the method go to the bottom statement
            }
            Balance += Amount; // same as Balance = Balance + Amount;
            return true;
        }

        public bool Withdraw(decimal Amount)
        {
            if (Amount <= 0)
            {
                Console.WriteLine($"Amount cannot be zero or negative.");
                return false;
            }
            if (Amount > Balance)
            {
                Console.WriteLine($"Insufficient Funds!");
                return false;
            }
            Balance -= Amount;
            return true;
        }

        public bool Transfer(decimal Amount, Account ToAccount)
        {
            if (Amount <= 0)
            {
                Console.WriteLine($"Amount cannot be zero or negative.");
                return false;
            }
            if(Withdraw(Amount))
            {
                ToAccount.Deposit(Amount);
                return true;
            }
            return false;
        }
    }
}
            //var success = Withdraw(Amount);
            //if(!success)
            //{
            //    return false;
            //}
