using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Manager : Employee
    {
        private string list;
        List<Employee> employees = new List<Employee>();

        public Manager(string id,string firstname,string lastname,decimal salary,Departments department)
            : base(id, firstname, lastname,salary,department)
        {
            
        }
        public void AddEmployee(Employee employee)
        {
            this.employees.Add(employee);
        }

        public List<Employee> Employees { get; set; }

        public override string ToString()
        {
           
            foreach (var item in employees)
            {
                list += item + "\n\n";
            }
            return "Id:" + this.Id + "\nFirst Name:" + this.FirstName + "\nSalary:" + this.Salary + "\nDepartment:" +
                this.Department+"\n\nEmployees List:\n"+this.list;
        }
    }
}
