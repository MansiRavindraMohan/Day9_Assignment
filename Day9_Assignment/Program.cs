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
            FirstName FName = new FirstName();
            Console.WriteLine("Please enter the First name:");

            string firstName = Console.ReadLine();
            bool val = FName.validateFirstName(firstName);

            if (val)
            {
                Console.WriteLine("First name matched");
            }
            else
            {
                Console.WriteLine("First name not matched");
            }
            Console.ReadLine();
        }
    }
}
