using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empOne = new Employee(1, "Sam",3, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            Employee empTwo = new Employee(2, "Smith", 3, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture)); 
            Employee empThree = new Employee(3, "Harvey", 3, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture)); 
            Employee empFour = new Employee(4, "Specter", 3, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            Employee empFive = new Employee(5, "Mike", 4, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture));

            DirectReport dirOne = new DirectReport(empOne, "SPS200");
            DirectReport dirTwo = new DirectReport(empTwo, "SPS200");
            DirectReport dirThree = new DirectReport(empThree, "SPS200");
            DirectReport dirFour = new DirectReport(empFour, "SPS200");
            DirectReport dirFive = new DirectReport(empFive, "SPS200");

            List<Employee> lstDirectReports = new List<Employee>();
            lstDirectReports.Add(empOne);
            lstDirectReports.Add(empTwo);
            lstDirectReports.Add(empThree);
            lstDirectReports.Add(empFour);
            lstDirectReports.Add(empFive);


            Employee manager=new Employee(1001, "Fred", 10, DateTime.ParseExact("01-12-2001", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            Manager manEmp = new Manager(manager, lstDirectReports, "SPS001");

            var lst=manEmp.GetMyReports();
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

       
    }
}
