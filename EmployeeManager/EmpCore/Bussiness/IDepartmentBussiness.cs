using EmpCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpCore.Bussiness
{
    public interface IDepartmentBussiness
    {
        List<Department> GetDepartment();
        List<Department> GetDepartmentCondition(Func<Department, bool> predicate);
        ResponceResult<Department> AddDepartment(Department department);
        ResponceResult<Department> UpdateDepartment(Department department);
        ResponceResult<Department> DeleteDepartment(string departmentName);
    }
}
