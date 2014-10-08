using System;

namespace Bank
{
    class Customer
    {
        private string type;

        public Customer(string type)
        {
            this.Type = type;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
    }
}
