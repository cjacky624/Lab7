using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {

            string userName = NameValidation();
            string userEmail = EmailValidation();
            string userPhoneNum = PhoneValidation();
            string userBirthDate = DateValidation();

        }


        public static string NameValidation()
        {
            Console.WriteLine("What is your name?");
            //input
            string userName = Console.ReadLine();

            //processing
            while (!Regex.IsMatch(userName, @"^[A-Z]+[A-z]{2,29}$")) //Need quotation marks because it is a string. while! = while not.
                                                                     //No white space within expression unless you want the white space.
            {
                Console.WriteLine("I'm sorry! That's not a valid name.");
                userName = Console.ReadLine();
            }

            //output
            return userName;

        }

        public static string EmailValidation()
        {
            Console.WriteLine("What is your email address?");
            string userEmail = Console.ReadLine();

            //"^[\w\d]{5,30}@[\w\d]{5,10}\.[\w\d]{2,3}$" \. Escapes . because it different meaning. Normal meaning for . is 1 character.
            while (!Regex.IsMatch(userEmail, @"^[\w\d]{5,30}@[\w\d]{5,10}\.[\w\d]{2,3}$"))
            {
                Console.WriteLine("I'm sorry! That is not a valid email address.");
                userEmail = Console.ReadLine();

            }
            return userEmail;
        }

        public static string PhoneValidation()
        {
            Console.WriteLine("What is your phone number?");
            string userPhoneNum = Console.ReadLine();
            while (!Regex.IsMatch(userPhoneNum, @"[\d]{3}-[\d]{3}-[\d]{4}$"))
            {
                Console.WriteLine("I'm sorry! That is not a valid phone number.");
                userPhoneNum = Console.ReadLine();

            }
            return userPhoneNum;

        }

        public static string DateValidation()
        {
            Console.WriteLine("What is your date of birth?");
            string userBirthDate = Console.ReadLine();
            while (!Regex.IsMatch(userBirthDate, @"[0-3]{1}[0-9]{1}/[0-1]{1}[0-9]{1}/[\d]{4}"))
            {
                Console.WriteLine("I'm sorry! That is not a valid date of birth.");
                userBirthDate = Console.ReadLine();

            }
            return userBirthDate;
        }
    }
}
