/*
     Define a class Customer, which contains data about a customer – first name, middle name and last name, ID (EGN),
     permanent address, mobile phone, e-mail, list of payments and customer type. 
    •Define a class Payment which holds a product name and price.
    •Define an enumeration for the customer type, holding the following types of customers: One-time ,
     Regular, Golden, Diamond.
    •Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and
     operators == and !=.
    •Implement the ICloneable interface. The Clone() method should make a deep copy of all object fields into a
     new object of type Customer.
    •Implement the IComparable<Customer> interface to compare customers by full name
     (as first criteria, in lexicographic order) and by ID (as second criteria, in ascending order).

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class TestCustomerSystem
    {
        static void Main()
        {
            CustomerType typeGolden=CustomerType.Golden;
            CustomerType typeDiamond = CustomerType.Diamond;
            Payment easyPay = new Payment("EasyPay", 200);
            Payment ePay = new Payment("EPay", 400);

            Customer firstTestCustomer = new Customer("Ivan", "Ivanov", "Draganov", "200", "Sofia", "0882222", "a@a.b",typeGolden);
            Customer secondTestCustomer = new Customer("Zenit", "Zenitov", "Krokodilov", "400", "Sofia", "555", "b@a.b",typeDiamond);

            firstTestCustomer.AddPayment(easyPay);

            Console.WriteLine(firstTestCustomer.ToString());
            Console.WriteLine(secondTestCustomer.ToString());
            Console.WriteLine(firstTestCustomer.CompareTo(secondTestCustomer));

            Customer copyOfFirst = firstTestCustomer;
            Customer firstCustomerCloned = (Customer)firstTestCustomer.Clone();

            copyOfFirst.FirstName = "Hi";

            Console.WriteLine(copyOfFirst);
            Console.WriteLine(firstTestCustomer);
            Console.WriteLine(firstCustomerCloned);


        }
    }
}
