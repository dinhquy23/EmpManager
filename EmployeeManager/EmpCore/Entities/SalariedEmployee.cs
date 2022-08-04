using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpCore.Entities
{
    //CommisstionRate, GrossSales, BasicSalary;
    public class SalariedEmployee:Employee
    {
        public double CommisstionRate { get; set; }
        public double GrossSales { get; set; }
        public double BasicSalary { get; set; }

        public SalariedEmployee() { }

        public SalariedEmployee(string ssn, string lastName, string firstname, string birthDay, string phone, string email, double commisstionRate, double grossSales,double basicSalary)
            :base(ssn,lastName,firstname,birthDay,phone,email)
        {
            CommisstionRate = commisstionRate;
            GrossSales = grossSales;
            BasicSalary = basicSalary;
        }

    }
}
