using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class SalesEmployee : Employee
    {
        List<Sales> sales = new List<Sales>();

        public SalesEmployee(string id,string firstname,string lastname,decimal salary, Departments department,List<Sales> sales)
            : base(id, firstname, lastname, salary, department)
        {
            this.Sales = sales;
        }

        public List<Sales> Sales { get; set; }
    }
}
