using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class Employee
    {


        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int EmpLevel { get; set; }
        private int NoOfLeaves { get; }
        public DateTime DateOfJoining { get; set; }

        public Employee()
        {
            //Default number of leaves credited is 2 per month based on date of joining to the current date
            NoOfLeaves= GetMonthDifference(DateOfJoining, DateTime.Now) * 2;
        }
        public Employee(int eID,string eName,int eLevel, DateTime eDoJ)
        {
            this.EmpID = eID;
            EmpName = eName;
            EmpLevel = eLevel;
            DateOfJoining = eDoJ;

        }

        public static int GetMonthDifference(DateTime startDate, DateTime endDate)
        {
            int monthsApart = 12 * (startDate.Year - endDate.Year) + startDate.Month - endDate.Month;
            return Math.Abs(monthsApart);
        }

    }
}
