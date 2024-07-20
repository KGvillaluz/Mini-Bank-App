using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    internal class UsersNew
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public UsersNew(string firstName, string lastName, string email, int pin, int confirmPin)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Pin = pin;
            ConfirmPin = confirmPin;
        }

        public string Email { get; set; }
        public int Pin {  get; set; }
        public int ConfirmPin {  get; set; }


    }
}
