using EmpCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpCore.DataAccessLayer
{
    public interface IDepartmentDAL
    {
        List<Department> GetAll();
        List<Department> Find(Func<Department, bool> predicate);
        Department GetById(string id);
        ResponceResult<Department> Create(Department department);
        ResponceResult<Department> Delete(string departmentName);
        ResponceResult<Department> Update(Department department);


    }
}
