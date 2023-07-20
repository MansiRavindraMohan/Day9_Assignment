using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Email eMail = new Email();
            Console.WriteLine("Please enter the Email:");

            string email = Console.ReadLine();
            bool val = eMail.ValidateEmail(email);

            if (val)
            {
                Console.WriteLine("Email matched");
            }
            else
            {
                Console.WriteLine("Email not matched");
            }
            Console.ReadLine();
        }
    }
}
