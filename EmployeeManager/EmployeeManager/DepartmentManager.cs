using EmpCore.Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpUI
{
    public class DepartmentManager
    {
        private readonly IEmployeeBussiness _employeeBussiness;
        private readonly IDepartmentBussiness _departmentBussiness;
        public DepartmentManager(IEmployeeBussiness employee, IDepartmentBussiness department)
        {
            _employeeBussiness = employee;
            _departmentBussiness = department;
        }
    }
}
