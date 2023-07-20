using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day9_Assignment
{
    public class Password
    {
        public const string Regex_Password = "^[A-Z]{1}[!@#$%^&*?<>0-9a-zA-Z]{7}$";
        public bool ValidatePassword(string Pass)
        {
            return Regex.IsMatch(Pass, Regex_Password);
        }
    }
}
