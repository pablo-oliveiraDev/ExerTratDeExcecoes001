using System;
using System.Globalization;
using exercicioExcecoes.Entities;
using exercicioExcecoes.Entities.Exceptions;


namespace exercicioExcecoes
{
    public class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Account account = new Account(number, holder, balance, withdrawLimit);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            try
            {


                account.Withdraw(amount);
                Console.Write("New Balance: " + account.Balance.ToString("F2",CultureInfo.InvariantCulture));
            }
            catch (FormatException e)
            {
                Console.WriteLine("error in format" + e.Message);
            }
            catch (AccountExceptions e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);

            }
        }
    }
}
