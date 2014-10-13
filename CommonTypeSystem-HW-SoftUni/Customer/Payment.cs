using System;
namespace Customer
{
    class Payment
    {
        public Payment(string name, decimal price)
        {
            this.ProductName = name;
            this.Price = price;
        }

        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
