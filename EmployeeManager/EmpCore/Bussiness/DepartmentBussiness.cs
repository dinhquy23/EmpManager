using EmpCore.DataAccessLayer;
using EmpCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpCore.Bussiness
{
    public class DepartmentBussiness : IDepartmentBussiness
    {
        private DepartmentDAL departmentDAL;
        public DepartmentBussiness()
        {
            departmentDAL = new DepartmentDAL();
        }

        public ResponceResult<Department> AddDepartment(Department department)
        {
            try
            {
                var dpm=departmentDAL.Find(item=>item.DepartmentName==department.DepartmentName);
                if(dpm!=null)
                {
                    departmentDAL.Create(department);
                    return new ResponceResult<Department>();
                }
                return new ResponceResult<Department>($"Department have name {department.DepartmentName} is exist");
            }
            catch(Exception ex)
            {
                return new ResponceResult<Department>($"{ex.Message}");
            }
        }

        public ResponceResult<Department> DeleteDepartment(string departmentName)
        {
            try
            {
                var dpm = departmentDAL.Find(item => item.DepartmentName == departmentName);
                if (dpm != null)
                {
                    departmentDAL.Delete(departmentName);
                    return new ResponceResult<Department>();
                }
                return new ResponceResult<Department>($"Department have name {departmentName} is not exist");
            }
            catch (Exception ex)
            {
                return new ResponceResult<Department>($"{ex.Message}");
            }
        }

        public List<Department> GetDepartment()=>departmentDAL.GetAll();

        public List<Department> GetDepartmentCondition(Func<Department, bool> predicate)
        {
            return departmentDAL.Find(predicate);
        }

        public ResponceResult<Department> UpdateDepartment(Department department)
        {
            try
            {
                var dpm = departmentDAL.Find(item => item.DepartmentName == department.DepartmentName);
                if (dpm != null)
                {
                    departmentDAL.Update(department);
                    return new ResponceResult<Department>();
                }
                return new ResponceResult<Department>($"Department have name {department.DepartmentName} is not exist");
            }
            catch (Exception ex)
            {
                return new ResponceResult<Department>($"{ex.Message}");
            }
        }
    }
}
