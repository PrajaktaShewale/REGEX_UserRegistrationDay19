using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UserRegistration
{
    internal class ValidUserInfo
    {
        public static string FIRSTNAME = "^[A-Z]{1}[a-z]{2,}";
        public static string LASTNAME = "^[A-Z]{1}[a-z]{2,}";
        public static string EMAIL = "^[0-9A-Za-z]+([.][0-9A-Za-z]+)[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";

        public bool validateFirstName(string fname)
        {
            return Regex.IsMatch(fname, FIRSTNAME);
        }
        public bool validateLastName(string lname)
        {
            return Regex.IsMatch(lname, LASTNAME);
        }
        public bool validateEmail(string mail)
        {
            return Regex.IsMatch(mail, EMAIL);
        }
       
        

    }

}
