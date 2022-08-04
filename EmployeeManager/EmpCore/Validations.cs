using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace EmpCore
{
    public static class Validations
    {
        public static bool IsBirthDay(this string birthDay)
        {
            return Regex.IsMatch(birthDay, @"^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}$");
        }

        public static bool IsPhone(this string phone)
        {
            if(phone.Length>7)
            {
                return phone.All(item => char.IsDigit(item));
            }
            return false;
        }

        public static bool IsEmail(this string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[A-Z]{2,4}$");
        }
    }
}
