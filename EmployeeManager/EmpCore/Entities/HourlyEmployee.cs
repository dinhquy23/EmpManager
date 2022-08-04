using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpCore.Entities
{
    public class HourlyEmployee:Employee
    {
        public double Wage { get; set; }
        public double WorkingHours { get; set; }
        public HourlyEmployee() { }
        public HourlyEmployee(string ssn, string firstName, string lastName, string birthDay, string phone, string email, double wage, double workingHours)
        : base(ssn, firstName, lastName, birthDay, phone, email)
        {
            this.Wage = wage;
            this.WorkingHours = workingHours;
        }
    }
}
