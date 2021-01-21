using System;


namespace exercicioExcecoes.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WhitdrawLimit { get; set; }
        public Account()
        {

        }

        public Account(int number, string holder, double balance, double whitdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WhitdrawLimit = whitdrawLimit;
        }

        public void Deposit(double amount)
        {
             Balance += amount;
        }
        public void Whitdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
