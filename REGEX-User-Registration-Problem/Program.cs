using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REGEX_User_Registration_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Regular Expression");
            Console.WriteLine("Enter your first name");
            string FirstName = Console.ReadLine(); // Creating user input for first name
            Validation.FirstNameValidation(FirstName);//Calling method to validate firstname

        }
    }
}
