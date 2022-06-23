using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Welcome to AddressBook DataTable Using LinQ");
            Linq_Operations lopr = new Linq_Operations();

            //UC1&2(CreateAddressBook)
            lopr.CreateAddressBook();

            //UC3(InsertValues)     //UC9 Add new Columns
            Console.WriteLine("Insertion of Contacts");
            lopr.InsertValues();
            lopr.DisplayDataTable();
            Console.WriteLine("\n\n\n");

            //UC4(EditContact)
            Console.WriteLine("Editing a contact");
            lopr.EditExistingContact();
            Console.WriteLine("\n\n\n");

            //UC5(DeleteContact)
            Console.WriteLine("Deleting a contact");
            lopr.DeleteContact("Sweta");
            lopr.DisplayDataTable();
            Console.WriteLine("\n\n\n");

            //UC6(Retrieve By City and State)
            Console.WriteLine("Searching for contacts from Bhilai(city)");
            lopr.RetrieveContactsByCity("Bhilai");
            Console.WriteLine("\n");
            Console.WriteLine("Searching for contacts from W.B.(state)");
            lopr.RetrieveContactsByState("W.B.");

            //UC7(Count By City or State)
            Console.WriteLine("City wise Count of Contacts");
            lopr.CountByCity();
            Console.WriteLine("\nState wise Count of Contacts");
            lopr.CountByState();

            //UC8(Alphabetical order of contacts belonging to a given city
            Console.WriteLine("Contacts belonging to Bhilai");
            lopr.AlphabeticalOrderofContactsByName("Bhilai");

            //UC10(Count By AddressBook Type)
            Console.WriteLine("\n\nType wise Count of Contacts");
            lopr.CountContactsByContactType();
        }
    }
}
