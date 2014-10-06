using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Person : IPerson
    {
        public string id;
        public string firstname;
        public string lastname;

        public Person(string id, string firstname, string lastname)
        {
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return "ID:" + this.Id + "\nFirst Name:" + this.FirstName + "\nLast Name:" + this.LastName;
        }
    }
}
