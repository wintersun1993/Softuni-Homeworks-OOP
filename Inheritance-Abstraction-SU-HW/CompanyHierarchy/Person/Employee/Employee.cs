using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Employee : Person
    {
        private decimal salary;
        private Departments department;
        

        public Employee(string id,string firstname,string lastname,decimal salary, Departments department)
            : base(id,firstname,lastname)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary { get; set; }
        public Departments Department { get; set; }
    }
}
