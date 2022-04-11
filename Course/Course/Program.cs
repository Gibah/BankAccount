using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account;

            Console.Write("Enter account number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter Account's Owner Name: ");
            string holder = Console.ReadLine();

            Console.Write("Will there be an initial deposit?(y/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 'y' || resp == 'Y')
            {
                Console.Write("Enter the initial deposit amount: ");
                double initialDeposit= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new BankAccount(number, holder, initialDeposit);
            }
            else
            {
                account = new BankAccount(number, holder);
            }

            Console.WriteLine();
            Console.WriteLine("Bank Account Details: ");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.WriteLine("Enter a Deposit Amount: ");
            double amount = double.Parse(Console.ReadLine());
            account.Deposit(amount);

            Console.WriteLine();
            Console.WriteLine("Updated Bank Account Details: ");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.WriteLine("Enter a Withdrawal Amount: ");
            Console.WriteLine("Note: Withdrawals have 5% discount...");
            double withDraw = double.Parse(Console.ReadLine());
            account.WithDraw(withDraw);

            Console.WriteLine();
            Console.WriteLine("Updated Bank Account Details: ");
            Console.WriteLine(account);

        }
    }
}
