using System;
using Upcasting_Downcasting.Entities;
using System.Globalization;

namespace Upcasting_Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500.00);

            //Upcasting

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0, 200.00);
            Account acc3 = new SavingsAccount(1004, "Ana", 0, 0.01);

            //Downcasting

            //BusinessAccount acc4 = (BusinessAccount)acc2;
            BusinessAccount acc4 = acc2 as BusinessAccount;

            acc4.Loan(100.00);

            //BusinessAccount acc5 = (BusinessAccount)acc3; quebra em tempo de execução

            if(acc3 is BusinessAccount)
            {
                // BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; // mais elegante!
                acc5.Loan(200.00);
                Console.WriteLine("Successfull Loan");
            }

            if(acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.updateBalance();
                Console.WriteLine("Successfull Update");

            }
        }
    }
}
