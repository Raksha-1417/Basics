using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;//import manually

namespace Basics
{
    internal class RegExp
    {
        public static void Main()
        {
            email();

            mobile();

        }
        public static void email()
        {
            Console.WriteLine("Email-Validation");
            string email_id = "john@gmail.com";
            var validate_email = Regex.IsMatch(email_id, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            Console.WriteLine(validate_email);
        }
        public static void mobile()
        {
            Console.WriteLine("Mobile-Validation");
            string mobile = "123-4567-890";
            var validate_mobile = Regex.IsMatch(mobile, @"\(?([0-9]{3})\)?[-.]?([0-9]{4})?[-.]?([0-9]{3})\)");
            Console.WriteLine(validate_mobile);
        }
    }
}
