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
            LastName LName = new LastName();
            Console.WriteLine("Please enter the Last name:");

            string lastName = Console.ReadLine();
            bool val = LName.validateLastName(lastName);

            if (val)
            {
                Console.WriteLine("Last name matched");
            }
            else
            {
                Console.WriteLine("Last name not matched");
            }
            Console.ReadLine();
        }
    }
}
