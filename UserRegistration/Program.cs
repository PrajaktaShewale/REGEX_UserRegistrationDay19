using System;
using System.Text.RegularExpressions;//namespace for regex
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            ValidUserInfo re = new ValidUserInfo();
            Console.WriteLine("Enter first Name");
            string first = Convert.ToString(Console.ReadLine());
            Console.WriteLine(re.validateFirstName(first));
            Console.WriteLine("Enter Last Name");
            string last = Convert.ToString(Console.ReadLine());
            Console.WriteLine(re.validateLastName(last));
        }        
    }
}