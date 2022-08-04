using EmpCore.Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpUI
{
    public class EmployeeManger
    {
        private readonly IEmployeeBussiness _employeeBussiness;
        public EmployeeManger(IEmployeeBussiness empbussiness)
        {
            _employeeBussiness = empbussiness;
        }

    }
}
