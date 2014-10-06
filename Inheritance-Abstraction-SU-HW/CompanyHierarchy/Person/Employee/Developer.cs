using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Developer : Employee
    {
        List<Projects> projects = new List<Projects>();
        private string list;

        public Developer(string id, string firstname, string lastname, decimal salary, Departments department)
            : base(id, firstname, lastname, salary, department)
        {
            
        }
       
        public void AddProject(Projects project)
        {
            this.projects.Add(project);
        }

        public List<Projects> Projects { get; set; }

        public override string ToString()
        {

            foreach (var item in projects)
            {
                list += item + "\n\n";
            }
            return "Id:" + this.Id + "\nFirst Name:" + this.FirstName + "\nSalary:" + this.Salary + "\nDepartment:" +
                this.Department + "\n\n Projects List:\n" + this.list;
        }
    }
}
