using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class BankAccount
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int number, string holder)
        {
            Number = number;
            Holder = holder;
        }

        public BankAccount(int number, string holder, double initialDeposit) : this(number, holder)
        {
            Deposit(initialDeposit);
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public override string ToString()
        {
            return "Account "
                + Number
                + ", Holder: "
                + Holder
                + ", Withdraw: $ "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
