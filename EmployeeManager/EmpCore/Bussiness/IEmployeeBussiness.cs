using EmpCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpCore.Bussiness
{
    public interface IEmployeeBussiness
    {
        List<Employee> GetEmployee();
        List<Employee> GetEmpCondition(Func<Employee, bool> predicate);
        ResponceResult<Employee> AddEmployee(Employee employee);
        ResponceResult<Employee> UpdateEmployee(Employee employee);
        ResponceResult<Employee> DeleteEmployee(string id);
    }
}
