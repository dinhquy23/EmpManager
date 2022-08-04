using EmpCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpCore.DataAccessLayer
{
    public class DepartmentDAL : IDepartmentDAL
    {
        private static List<Department> _departments;
        static DepartmentDAL()
        {
            _departments = new List<Department>()
            {
                new Department()
                {
                    DepartmentName="OS1",
                    ListEmployee=new List<Employee>()
                    {
                        new HourlyEmployee(){SSN="1",FirstName="Quy",LastName="Nguyen Dinh",BirthDay="23/12/2021",Phone="1234567", Email="abc@gmail.com", Wage=12, WorkingHours=45},
                        new HourlyEmployee(){SSN="2",FirstName="Tuan",LastName="Pham Anh",BirthDay="23/12/2021",Phone="1234567",Email="abc@gmail.com", Wage=12, WorkingHours=45},
                        new SalariedEmployee(){SSN="5",FirstName="Quang",LastName="Bui Van",BirthDay="23/12/2021",Phone="1234567",Email="abc@gmail.com",BasicSalary=2000, CommisstionRate=20, GrossSales=10}
                    }
                },
                new Department()
                {
                    DepartmentName="OS3",
                    ListEmployee=new List<Employee>()
                    {
                        new HourlyEmployee(){SSN="3",FirstName="Long",LastName="Bui Huy",BirthDay="23/12/2021",Phone="1234567",Email="abc@gmail.com", Wage=12, WorkingHours=45},
                        new SalariedEmployee(){SSN="4",FirstName="Linh",LastName="Vi Dieu",BirthDay="23/12/2021",Phone="1234567",Email="abc@gmail.com", BasicSalary=2000, CommisstionRate=20, GrossSales=10},
                        new SalariedEmployee(){SSN="6",FirstName="Hoang",LastName="Nguyen Huy",BirthDay="23/12/2021",Phone="1234567",Email="abc@gmail.com",BasicSalary=2000, CommisstionRate=20, GrossSales=10}
                    }
                }
            };
        }

        public ResponceResult<Department> Create(Department department)
        {
            _departments.Add(department);
            return new ResponceResult<Department>();
        }

        public ResponceResult<Department> Delete(string departmentName)
        {
            var department = _departments.FirstOrDefault(item => item.DepartmentName == departmentName);
            _departments.Remove(department);
            return new ResponceResult<Department>();
        }

        public List<Department> Find(Func<Department, bool> predicate)
        {
            var result = _departments.Where(predicate).ToList();
            return result;
        }

        public List<Department> GetAll() => _departments;

        public Department GetById(string id)
        {
            throw new NotImplementedException();
        }

        public ResponceResult<Department> Update(Department department)
        {
            var dpm = _departments.FirstOrDefault(item => item.DepartmentName == department.DepartmentName);
            _departments.Remove(dpm);
            _departments.Add(department);
            return new ResponceResult<Department>();
        }
    }
}
