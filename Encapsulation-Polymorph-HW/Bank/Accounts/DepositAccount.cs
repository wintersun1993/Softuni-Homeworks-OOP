using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class DepositAccount : Account, IDeposit, IWithdraw
    {
        public DepositAccount(Customer customer, double balance, double interestrate)
            : base(customer, balance, interestrate)
        {

        }


        public void Withdraw(double money)
        {
            Balance -= money;
        }

        public void Deposit(double money)
        {
            Balance += money;
        }

        public override double Interest(double months)
        {
            if (Balance > 1000)
            {
                return Balance * (1 + (IntRate * months)/100);
            }
            else
            {
                return 0;
            }
        }
    }
}
