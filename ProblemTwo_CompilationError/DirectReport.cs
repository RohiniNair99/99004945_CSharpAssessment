using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class DirectReport:Employee
    {
        public Employee ReportsTo { get; set; }
        public string ProjectCode { get; set; }

        public DirectReport(Employee managerEmpObj,string pCode) :base(managerEmpObj.EmpID, managerEmpObj.EmpName, managerEmpObj.EmpLevel,managerEmpObj.DateOfJoining)
        {
            ReportsTo = managerEmpObj;
            ProjectCode = pCode;
        }
    }
}
