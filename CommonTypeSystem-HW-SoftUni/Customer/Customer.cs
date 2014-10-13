using System;
using System.Collections.Generic;

namespace Customer
{
    class Customer : IComparable<Customer>, ICloneable
    {
        List<Payment> payments = new List<Payment>();

        public Customer() { }

        public Customer(string firstName, string middleName, string lastName, string id, string permanentAddres,
                        string mobilePhone, string eMail,CustomerType type)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = id;
            this.PermanentAddress = permanentAddres;
            this.MobilePhone = mobilePhone;
            this.Email = eMail;
            this.Type = type;
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string ID { get; set; }

        public string PermanentAddress { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public CustomerType Type { get; set; }

        public List<Payment> Payments { get; set; }

        public void AddPayment(Payment pay)
        {
            payments.Add(pay);
        }
        
        protected bool Equals(Customer otherCustomer)
        {
            return string.Equals(FirstName, otherCustomer.FirstName) &&
                string.Equals(MiddleName, otherCustomer.MiddleName) &&
                string.Equals(LastName, otherCustomer.LastName) && ID == otherCustomer.ID;
        }

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;

            if (customer == null)
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((Customer)obj);
        }

        public static bool operator ==(Customer first, Customer second)
        {
            return first.Equals(second);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return this.ID.GetHashCode();
            }
        }

        public static bool operator !=(Customer first, Customer second)
        {
            return first.Equals(second);
        }

        public int CompareTo(Customer otherCustomer)
        {
            string first = this.ToString();
            string second = otherCustomer.ToString();
            if(first.CompareTo(second)==0)
            {
               return this.ID.CompareTo(otherCustomer.ID);
            }

            return first.CompareTo(second);
        }

        public override string ToString()
        {
            return String.Format("Customer First Name:{0} \nMiddle Name:{1}\nLastName:{2}", this.FirstName, this.MiddleName, this.LastName);
        }

        public object Clone()
        {
            return new Customer()
            {
                FirstName=this.FirstName,
                MiddleName=this.MiddleName,
                LastName=this.LastName,
                ID=this.ID,
                PermanentAddress=this.PermanentAddress,
                MobilePhone=this.MobilePhone,
                Email=this.Email,
                Type=this.Type,
                Payments=this.Payments
            };
        }
    }
}
