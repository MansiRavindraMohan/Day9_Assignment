using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day9_Assignment
{
    public class MobileNo
    {
        public const string Regex_MobileNo = "^[0-9]{1,2}[ ][0-9]{10}$";
        public bool ValidateMobileNumber(string num)
        {
            return Regex.IsMatch(num, Regex_MobileNo);
        }
    }
}
