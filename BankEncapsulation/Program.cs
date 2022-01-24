using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAcct = new BankAccount(250.00);
            Console.WriteLine("New Bank Account Created");

            Console.WriteLine($"Your Balance is: {myAcct.GetBalance()}");

            var secondAcct = new BankAccount();
            Console.WriteLine("2nd Account created");
            
            Console.WriteLine($"Your 2nd Account Balance is: {secondAcct.GetBalance()}");

            secondAcct.Deposit(300.00);
            Console.WriteLine("Deposit Confirmed!");
            Console.WriteLine($"New Balance is: {secondAcct.GetBalance()}");

        }
    }
}
