using EmpCore.DataAccessLayer;
using EmpCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpCore.Bussiness
{
    public class EmployeeBussiness : IEmployeeBussiness
    {
        private EmployeeDAL employeeDAL;

        public EmployeeBussiness()
        {
            employeeDAL = new EmployeeDAL();
        }
        public ResponceResult<Employee> AddEmployee(Employee employee)
        {
            try
            {
                var emp=employeeDAL.Find(item=>item.SSN==employee.SSN);
                if(emp==null)
                {
                    employeeDAL.Create(employee);
                    return new ResponceResult<Employee>();
                }
                return new ResponceResult<Employee>($"Employee {employee} is exist");
            }
            catch(Exception ex)
            {
                return new ResponceResult<Employee>($"{ex.Message}");
            }
        }

        public ResponceResult<Employee> DeleteEmployee(string id)
        {
            try
            {
                var emp = employeeDAL.Find(item => item.SSN == id);
                if(emp!=null)
                {
                    employeeDAL.Delete(id);
                    return new ResponceResult<Employee>();
                }
                return new ResponceResult<Employee>($"Employee have SSN {id} is not exist");

            }
            catch(Exception ex)
            {
                return new ResponceResult<Employee>($"{ex.Message}");
            }
        }

        public List<Employee> GetEmpCondition(Func<Employee, bool> predicate)
        {
             return employeeDAL.Find(predicate);
        }

        public List<Employee> GetEmployee() => employeeDAL.Employees;

        public ResponceResult<Employee> UpdateEmployee(Employee employee)
        {
            try
            {
                var emp = employeeDAL.Find(item => item.SSN == employee.SSN);
                if (employee != null)
                {
                    employeeDAL.Update(employee);
                    return new ResponceResult<Employee>();
                }
                return new ResponceResult<Employee>($"Employee have SSN {employee.SSN} is not exist");
            }
            catch(Exception ex)
            {
                return new ResponceResult<Employee>($"{ex.Message}");
            }
            
        }

    }
}
