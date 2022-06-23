using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AddressBookLinQ
{
    public class ContactValidation
    {
        private string _regexFirstName = "^[A-Z][a-z]{2,}$";

        private string _regexLastName = "^[A-Z][a-z]{2,}$";

        private string _regexEmail = "^[A-Za-z0-9]+([._+-][A-Za-z0-9]+)*[@][A-Za-z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";

        private string _regexZipcode = "^[1-9][0-9]{5}$";

        private string _regexMobileNumber = "^[1-9][0-9]{9}$";

        public string _regexCityState = "^[A-Za-z]+([.-]?[A-Za-z][.-]+)*$";

        public string _regexAddress = "^[A-Za-z ]+([.-]?[A-Za-z0-9]+)*$";

        public string _regexABookNameType = "^[A-Za-z]{3,}$";


        public bool ValidateFirstName(string firstName) => Regex.IsMatch(firstName, _regexFirstName) ? true : throw new ContactException(ContactException.error.Invalid_Name, "Invalid First Name");
        public bool ValidateLastName(string lastName) => Regex.IsMatch(lastName, _regexLastName) ? true : throw new ContactException(ContactException.error.Invalid_Name, "Invalid Last Name");
        public bool ValidateCitySate(string cityState) => Regex.IsMatch(cityState, _regexCityState) ? true : throw new ContactException(ContactException.error.Invalid_CityState, "Invalid City or State");
        public bool ValidateAddress(string cityState) => Regex.IsMatch(cityState, _regexAddress) ? true : throw new ContactException(ContactException.error.Invalid_Address, "Invalid Address");
        public bool ValidateEmail(string email) => Regex.IsMatch(email, _regexEmail) ? true : throw new ContactException(ContactException.error.Invalid_Email, "Invalid Email");
        public bool ValidateZipcode(string password) => Regex.IsMatch(password, _regexZipcode) ? true : throw new ContactException(ContactException.error.Invalid_Zipcode, "Invalid Password");
        public bool ValidateABookNameType(string nameType) => Regex.IsMatch(nameType, _regexABookNameType) ? true : throw new ContactException(ContactException.error.Invalid_NameType, "Invalid Address Book Name or Type");
        public bool ValidateMobileNumber(string mobileNumber) => Regex.IsMatch(mobileNumber, _regexMobileNumber) ? true : throw new ContactException(ContactException.error.Invalid_Mobile, "Invalid Mobile Number");

        public bool CheckContactValidation(string fName, string lName, string address, string city, string state, string zipCode, string phoneNumber, string Email, string aBName, string aBType)
        {
            bool valid = false;
            if (ValidateFirstName(fName) && ValidateLastName(lName)&& ValidateAddress(address) && ValidateCitySate(city) && ValidateCitySate(state) && ValidateZipcode(zipCode) && ValidateMobileNumber(phoneNumber) && ValidateABookNameType(aBName) && ValidateABookNameType(aBType))
            {
                valid = true;
            }
            return valid;
        }

    }
}
