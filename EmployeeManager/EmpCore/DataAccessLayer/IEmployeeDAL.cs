using EmpCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpCore.DataAccessLayer
{
    public interface IEmployeeDAL
    {
        List<Employee> Employees { get; }
        ResponceResult<Employee> Create(Employee emp);
        List<Employee> Find(Func<Employee, bool> predicate);
        ResponceResult<Employee> Delete(string id);
        ResponceResult<Employee> Update(Employee emp);
    }
}
