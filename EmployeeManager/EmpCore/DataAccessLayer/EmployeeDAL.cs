using EmpCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpCore.DataAccessLayer
{
    public class EmployeeDAL : IEmployeeDAL
    {
        private static List<Employee> _employees;
        static EmployeeDAL()
        {
            _employees = new List<Employee>()
            {
                new HourlyEmployee(){SSN="1",FirstName="Quy",LastName="Nguyen Dinh",BirthDay="23/12/2021",Phone="1234567", Email="abc@gmail.com", Wage=12, WorkingHours=45},
                new HourlyEmployee(){SSN="2",FirstName="Tuan",LastName="Pham Anh",BirthDay="23/12/2021",Phone="1234567",Email="abc@gmail.com", Wage=12, WorkingHours=45},
                new HourlyEmployee(){SSN="3",FirstName="Long",LastName="Bui Huy",BirthDay="23/12/2021",Phone="1234567",Email="abc@gmail.com", Wage=12, WorkingHours=45},
                new SalariedEmployee(){SSN="4",FirstName="Linh",LastName="Vi Dieu",BirthDay="23/12/2021",Phone="1234567",Email="abc@gmail.com", BasicSalary=2000, CommisstionRate=20, GrossSales=10},
                new SalariedEmployee(){SSN="5",FirstName="Quang",LastName="Bui Van",BirthDay="23/12/2021",Phone="1234567",Email="abc@gmail.com",BasicSalary=2000, CommisstionRate=20, GrossSales=10},
                new SalariedEmployee(){SSN="6",FirstName="Hoang",LastName="Nguyen Huy",BirthDay="23/12/2021",Phone="1234567",Email="abc@gmail.com",BasicSalary=2000, CommisstionRate=20, GrossSales=10},

            };
        }

        public List<Employee> Employees => _employees;

        public ResponceResult<Employee> Create(Employee emp)
        {
            _employees.Add(emp);
            return new ResponceResult<Employee>();
        }

        public ResponceResult<Employee> Delete(string id)
        {
            var employee = _employees.FirstOrDefault(item => item.SSN == id);
            _employees.Remove(employee);
            return new ResponceResult<Employee>();
        }

        public List<Employee> Find(Func<Employee, bool> predicate)
        {
            var result = _employees.Where(predicate).ToList();
            return result;
        }

        public ResponceResult<Employee> Update(Employee emp)
        {
            var employee=_employees.FirstOrDefault(item=>item.SSN==emp.SSN);
            _employees.Remove(employee);
            _employees.Add(emp);
            return new ResponceResult<Employee>();
        }
    }
}
