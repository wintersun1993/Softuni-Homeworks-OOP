using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Customer : Person
    {
        private decimal purchaseamount;

        public Customer(string id, string firstname, string lastname, decimal purchaseamount)
            :base(id,firstname,lastname)
        {
            this.PurchaseAmount = purchaseamount;
        }

        public decimal PurchaseAmount { get; set; }
    }
}
