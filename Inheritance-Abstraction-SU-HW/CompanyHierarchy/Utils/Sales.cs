using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Sales
    {
        private string productname;
        private DateTime date;
        private decimal price;

        public Sales(string productname, DateTime date, decimal price)
        {
            this.ProductName = productname;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}
