using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class Manager:Employee
    {
        public List<Employee> DirectReports { get; set; }
        public string CostCode { get; set; }

        public Manager(Employee obj,List<Employee> drEmployeesLst, string cCode):base(obj.EmpID, obj.EmpName,obj.EmpLevel,obj.DateOfJoining)
        {
            DirectReports = drEmployeesLst;
            CostCode = cCode;

        }

        public List<string> GetMyReports()
        {
            return DirectReports.Select(x => x.EmpName).ToList();
        }

    }
}
