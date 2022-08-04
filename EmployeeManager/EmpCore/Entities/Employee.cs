using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpCore.Entities
{
    public class Employee
    {
        private string _birthDay;
        private string _phone;
        private string _email;

        public string BirthDay
        {
            get => _birthDay;
            set
            {
                if(!value.IsBirthDay())
                {
                    throw new Exception("Ngay thang nam sinh khong phu hop");
                }
                _birthDay = value;
            }
        }
        public string Phone
        {
            get => _phone;
            set
            {

            }
        }
        public string Email
        {
            get=> _email;
            set
            {
                if(!value.IsEmail())
                {
                    throw new Exception("Email khong phu hop");
                }
                _email = value;
            }
        }
        public string SSN { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public Employee() { }

        public Employee(string ssn, string lastName, string firstname, string birthDay, string phone , string email)
        {
            SSN=ssn;
            LastName=lastName;
            FirstName = firstname;
            BirthDay=birthDay;
            Phone=phone;
            Email=email;
        }
    }
}
