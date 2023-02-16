using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_application
{
    internal class Savings : Account
    {

        public decimal InterestRate { get; set; } = 0.12m;

        public decimal PayInterest(int Months)
        {
            var interest = Balance * (InterestRate / 12) * Months;
            Deposit(interest);
            return interest;
        }

    }
}
