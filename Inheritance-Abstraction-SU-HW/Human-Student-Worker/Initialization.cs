using System;
using System.Collections.Generic;
using System.Linq;

class Initialization
{
    public static void Main()
    {
        Student gosho = new Student("Georgi", "Ivanov", "1010101");
        Student pesho = new Student("Petur", "Ivanov", "12121212");
        Student misho = new Student("Mihail", "Stefanov", "12345");
        Student ivan = new Student("Ivan", "Karamfilov", "151617");
        Student boris = new Student("Boris", "Nadali", "123456");
        Student boyan = new Student("Boyan", "Velikii", "1515151");
        Student boryan = new Student("Boryan", "Boryanov", "141214");
        Student bagrqn = new Student("Bagrqn", "Slabakov", "0022333");
        Student bogomil = new Student("Bogomil", "Bogorodov", "132321");
        Student stefan = new Student("Stefan", "Fernandov", "5555555");

        List<Student> listStudents = new List<Student>()
        {
            gosho,
            pesho,
            misho,
            ivan,
            boris,
            boyan,
            boryan,
            bagrqn,
            bogomil,
            stefan
        };

        Worker estatii = new Worker("Estatii", "Estatiev", 100, 4);
        Worker karamfil = new Worker("Karamfil", "Karamfilov", 400, 4);
        Worker lulqk = new Worker("Liulqk", "Ziumbiulov", 1000, 6);
        Worker keremidko = new Worker("Keremidko", "Tuhlev", 1200, 3);
        Worker stoycho = new Worker("Stoycho", "Troichev", 20, 1);
        Worker zdravko = new Worker("Zdravko", "Zdravkov", 200, 8);
        Worker petko = new Worker("Petur", "Tudjarov", 10000, 2);
        Worker mitko = new Worker("Dimitur", "Penev", 4000, 8);
        Worker toshko = new Worker("Toshko", "Toshkov", 2233, 4);
        Worker teodor = new Worker("Teodor", "Krustitelq", 500, 8);

        List<Worker> workers = new List<Worker>()
        {
            estatii,
            karamfil,
            lulqk,
            keremidko,
            stoycho,
            zdravko,
            petko,
            mitko,
            toshko,
            teodor
        };

        
        var sortedStudents = listStudents.OrderBy(st => st.facN);
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student.FirstName);
        }

        var sortedWorkers = workers.OrderByDescending(m => m.MoneyPerHour());
        foreach (var worker in sortedWorkers)
        {
            Console.WriteLine(worker.FirstName + string.Format("- money per hour: {0:N2}", worker.MoneyPerHour()));
        }
    }
}

