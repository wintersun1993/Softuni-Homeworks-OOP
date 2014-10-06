using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Projects
    {
        private string name;
        private DateTime date;
        private string details;
        private string state="open";

        public Projects(string name, DateTime date, string details, string state)
        {
            this.Name = name;
            this.Date = date;
            this.Details = details;
            this.State = state;
        }

        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Details { get; set; }
        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }

        public string CloseProject()
        {
            this.State = "closed";
            return this.State;
        }

        public override string ToString()
        {
            return "Name:" + this.Name + "\nState:" + this.State;
        }
    }
}
