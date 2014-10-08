using System;

namespace Bank
{
    class MortgageAccount : Account, IDeposit
    {
        public MortgageAccount(Customer customer, double balance, double interestrate)
            : base(customer, balance, interestrate)
        {

        }

        public void Deposit(double money)
        {
            Balance += money;
        }

        public override double Interest(double months)
        {
            if (Customer.Type.Equals("individual"))
            {
                if (months <= 6)
                {
                    return 0;
                }
                else
                {
                    return Balance * (1 + (IntRate * months)/100);
                }
            }
            
            else if (Customer.Type.Equals("company"))
            {
                if (months <= 12)
                {
                    return ((Balance * (1 + IntRate * months)/100)/2);
                }
                else
                {
                    return ((Balance * (1 + IntRate * months)/100) / 2) + (Balance * (1 + IntRate * (months-12)/100));
                }
            }
            
            else
            {
                return 0;
            }
        }
    }
}
