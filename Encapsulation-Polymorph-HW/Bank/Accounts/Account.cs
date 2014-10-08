using System;

namespace Bank
{
    abstract class Account
    {
        private Customer customer;
        private double balance;
        private double interestrate;

        public Account(Customer customer, double balance, double interestrate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.IntRate = interestrate;
        }

        public Customer Customer { get; set; }
        public double Balance { get; set; }
        public double IntRate { get; set; }

        public abstract double Interest(double months);
    }
}
