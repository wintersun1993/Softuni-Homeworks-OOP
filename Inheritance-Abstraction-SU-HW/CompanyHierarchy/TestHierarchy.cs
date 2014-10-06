using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class TestHierarchy
    {
        static void Main(string[] args)
        {
            Projects game = new Projects("Space Game", new DateTime(2014,2,4), "A space game", "open");
            Employee Mitko = new Employee("101010", "Dimitur", "Petkov", 100m, Departments.Marketing);
            Employee Stanimir = new Employee("101020", "Stanimir", "Dimitrov", 1000m, Departments.Marketing);
            Manager Ivan=new Manager("101212","Ivan","Petrov",200m,Departments.Marketing);
            Ivan.AddEmployee(Mitko);
            Ivan.AddEmployee(Stanimir);
            Developer Stoyan = new Developer("15", "Stoyan", "Dimov", 2000m, Departments.Production);
            Stoyan.AddProject(game);

            Console.WriteLine(Ivan.ToString());
            game.CloseProject();
            Console.WriteLine(Stoyan.ToString());
        }
    }
}
