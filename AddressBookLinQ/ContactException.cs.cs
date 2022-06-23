using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinQ
{
    public class ContactException : Exception
    {
        public enum error { Invalid_Name, Invalid_Email, Invalid_Zipcode, Invalid_Mobile, Invalid_Address, Invalid_CityState, Invalid_NameType };

        public error errorType;

        public ContactException(error error, string message) : base(message)
        {
            errorType = error;
        }
    }
}