using System;

namespace Bank
{
    class LoanAccount : Account, IDeposit
    {
        public LoanAccount(Customer customer, double balance, double interestrate)
            : base(customer, balance, interestrate)
        {

        }

        public void Deposit(double money)
        {
            Balance += money;
        }

        public override double Interest(double months)
        {
            if (months > 3 && Customer.Type.Equals("individual"))
            {
                return Balance * (1 + IntRate * (months - 3)/100);
            }
            else if (months > 2 && Customer.Type.Equals("company"))
            {
                return Balance * (1 + IntRate * (months - 2)/100);
            }
            else
            {
                return 0;
            }
        }
    }
}
