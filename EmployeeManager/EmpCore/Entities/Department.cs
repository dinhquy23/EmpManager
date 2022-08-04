using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpCore.Entities
{
    public class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> ListEmployee =new List<Employee>();

        public Department()
        { }
        public Department(string departmentName,List<Employee> listEmp)
        {
            DepartmentName = departmentName;
            ListEmployee = listEmp;
        }
    }
}
