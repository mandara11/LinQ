using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinQ
{
    public class Linq_Operations
    {
        // Create Data table to store address book details
        public DataTable dataTable = new DataTable();

        /// <summary>
        /// Add columns to the created data table
        /// </summary>
        public void CreateAddressBook()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zipcode", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("EmailID", typeof(string));
            dataTable.Columns.Add("ABookName", typeof(string));
            dataTable.Columns.Add("ABookType", typeof(string));
        }

        /// <summary>
        /// Method to insert rows(contacts) into the table
        /// </summary>
        public void InsertValues()
        {
            ContactValidation cvalid = new ContactValidation();
            try
            {
                cvalid.CheckContactValidation("Trina", "Maity", "HaldiaComplex", "Haldia", "W.B.", "165301", "8983456534", "trinamaity@gmail.com", "Friends", "Informal");
                dataTable.Rows.Add("Trina", "Maity", "HaldiaComplex", "Haldia", "W.B.", "165301", "8983456534", "trinamaity@gmail.com", "Friends", "Informal");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Bruce", "Banner", "Vandalia", "Dayton", "Florida", "454541", "7123425612", "hulkBuster@gmail.com", "Colleague", "Formal");
                dataTable.Rows.Add("Bruce", "Banner", "Vandalia", "Dayton", "Florida", "454541", "7123425612", "hulkBuster@gmail.com", "Colleague", "Formal");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Sweta", "Verma", "Ranchi Estate", "Ranchi", "JHK", "123122", "9889710434", "vermasweta@yahoo.com", "Professor", "Formal");
                dataTable.Rows.Add("Sweta", "Verma", "Ranchi Estate", "Ranchi", "JHK", "123122", "9889710434", "vermasweta@yahoo.com", "Professor", "Formal");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Sayantani", "Mondal", "IITKGP quaters", "Kharagpur", "WB", "100723", "7893264355", "smondal@gmail.com", "Colleague", "Formal");
                dataTable.Rows.Add("Sayantani", "Mondal", "IITKGP quaters", "Kharagpur", "W.B.", "100723", "7893264355", "smondal@gmail.com", "Colleague", "Formal");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Riya", "Srivastav", "Lajpat Nagar", "Delhi", "Delhi", "780431", "9856964579", "riyasriv@yahoo.com", "Cousin", "Informal");
                dataTable.Rows.Add("Riya", "Srivastav", "Lajpat Nagar", "Delhi", "Delhi", "780431", "9856964579", "riyasriv@yahoo.com", "Cousin", "Informal");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Tiasa", "Chakraborty", "RoyalPalace", "Kolkata", "W.B.", "223544", "7849876734", "chaktiasa@rediffmail.com", "Manager", "Formal");
                dataTable.Rows.Add("Tiasa", "Chakraborty", "RoyalPalace", "Kolkata", "W.B.", "223544", "7849876734", "chaktiasa@rediffmail.com", "Manager", "Formal");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Natasha", "Barman", "Jalpaiguri Estate", "Jalpaiguri", "W.B.", "178028", "9866735277", "natsbarman@gmail.com", "Cousin", "Informal");
                dataTable.Rows.Add("Natasha", "Barman", "Jalpaiguri Estate", "Jalpaiguri", "W.B.", "178028", "9866735277", "natsbarman@gmail.com", "Cousin", "Informal");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Priya", "Arya", "Sector1", "Bhilai", "C.G.", "490006", "8987224534", "arya7priya@gmail.com", "Sister", "Informal");
                dataTable.Rows.Add("Priya", "Arya", "Sector1", "Bhilai", "C.G.", "490006", "8987224534", "arya7priya@gmail.com", "Sister", "Informal");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Ishika", "Mitra", "Farid Nagar", "Faridabad", "Delhi", "100112", "6767986886", "jarvis@gmail.com", "Manager", "Formal");
                dataTable.Rows.Add("Ishika", "Mitra", "Farid Nagar", "Faridabad", "Delhi", "100112", "6767986886", "jarvis@gmail.com", "Manager", "Formal");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Alisha", "Sharma", "Sector8", "Bhilai", "C.G.", "178001", "9876543256", "sharmalaisha@yahoo.com", "Friends", "Informal");
                dataTable.Rows.Add("Alisha", "Sharma", "Sector8", "Bhilai", "C.G.", "178001", "9876543256", "sharmalaisha@yahoo.com", "Friends", "Informal");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Sheldon", "Cooper", "Street-4", "Bhilai", "C.G.", "525252", "9876778434", "cooper@yahoo.com", "Teacher", "Formal");
                dataTable.Rows.Add("Sheldon", "Cooper", "Street-4", "Bhilai", "C.G.", "525252", "9876778434", "cooper@yahoo.com", "Teacher", "Formal");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Siddhi", "Seth", "Gopal Vihar", "Jabalpur", "MadhyaPradesh", "856985", "7458658925", "siddhiseth@gmail.com", "Professor", "Formal");
                dataTable.Rows.Add("Siddhi", "Seth", "Gopal Vihar", "Jabalpur", "MadhyaPradesh", "856985", "7458658925", "siddhiseth@gmail.com", "Professor", "Formal");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cvalid.CheckContactValidation("Priyanka", "Chopra", "Street-5", "NewYork", "NewYork", "520147", "8201118267", "priyanka@gmail.com", "Teacher", "Formal");
                dataTable.Rows.Add("Priyanka", "Chopra", "Street-5", "NewYork", "NewYork", "520147", "8201118267", "priyanka@gmail.com", "Teacher", "Formal");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        /// <summary>
        /// Method to display all the contacts in the data table
        /// </summary>
        public void DisplayDataTable()
        {
            foreach (DataColumn col in dataTable.Columns)
            {
                Console.Write(col.ToString().PadRight(20));
            }
            Console.WriteLine("");
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn col in dataTable.Columns)
                {
                    Console.Write(row[col].ToString().PadRight(20));
                }
                Console.WriteLine();
            }
        }


        /// <summary>
        /// Edits the existing contact in datatable
        /// </summary>
        public void EditExistingContact()
        {
            string name = "Priyanka";
            var rowToUpdate = dataTable.AsEnumerable().Where(x => x.Field<string>("FirstName").Equals(name)).FirstOrDefault();
            if (rowToUpdate != null)
            {
                rowToUpdate.SetField("PhoneNumber", "8300987876");
                rowToUpdate.SetField("ZipCode", "534260");
                Console.WriteLine("\nPhoneNumber and ZipCode of {0} updated successfully!", name);
                DisplayDataTable();
            }
            else
            {
                Console.WriteLine("There is no such record in the Address Book!");
            }
        }


        /// <summary>
        /// Deleting a contact with the given name
        /// </summary>
        /// <param name="name">Firstname of the contact to be deleted</param>
        public void DeleteContact(string name)
        {
            var deleteRow = dataTable.AsEnumerable().Where(a => a.Field<string>("FirstName").Equals(name)).FirstOrDefault();
            if (deleteRow != null)
            {
                deleteRow.Delete();
                Console.WriteLine("Contact deleted successfully");
            }
        }


        /// <summary>
        /// Retrieve contacts of a particular city
        /// </summary>
        /// <param name="city">NAme of the city to be searched for</param>
        public void RetrieveContactsByCity(string city)
        {
            var cityResults = dataTable.AsEnumerable().Where(dr => dr.Field<string>("City") == city);
            foreach (DataRow row in cityResults)
            {
                foreach (DataColumn col in dataTable.Columns)
                {
                    Console.Write(row[col].ToString().PadRight(20));
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Retrieves contact of a particular state
        /// </summary>
        /// <param name="state">Name of the state to be searched for</param>
        public void RetrieveContactsByState(string state)
        {
            var stateResults = dataTable.AsEnumerable().Where(dr => dr.Field<string>("State") == state);
            foreach (DataRow row in stateResults)
            {
                foreach (DataColumn col in dataTable.Columns)
                {
                    Console.Write(row[col].ToString().PadRight(20));
                }
                Console.WriteLine();
            }
        }


        /// <summary>
        /// Displays count of contacts city wise
        /// </summary>
        public void CountByCity()
        {
            var query = from row in dataTable.AsEnumerable()
                        group row by row.Field<string>("City") into city
                        select new
                        {
                            City = city.Key,
                            CountOfCity = city.Count()
                        };
            Console.WriteLine("\nCount contacts by city in the Address Book :");
            Console.WriteLine("City\t\tCount");
            foreach (var distinctCity in query)
            {
                Console.WriteLine(distinctCity.City.PadRight(18) + distinctCity.CountOfCity);
            }
        }


        /// <summary>
        /// Displays count of contacts state wise
        /// </summary>
        public void CountByState()
        {
            var query = from row in dataTable.AsEnumerable()
                        group row by row.Field<string>("State") into state
                        select new
                        {
                            State = state.Key,
                            CountOfState = state.Count()
                        };
            Console.WriteLine("\nCount contacts by State in the Address Book :");
            Console.WriteLine("State\t\tCount");
            foreach (var distinctState in query)
            {
                Console.WriteLine(distinctState.State.PadRight(18) + distinctState.CountOfState);
            }
        }

        /// <summary>
        /// List all the contacts belonging to a city in alphabetical order
        /// </summary>
        /// <param name="city">Name of the city to get list of contacts</param>
        public void AlphabeticalOrderofContactsByName(string city)
        {
            Console.WriteLine("\nSorting Contacts By Name alphabetically for a given City :");
            foreach (DataColumn col in dataTable.Columns)
            {
                Console.Write(col.ToString().PadRight(14));
            }
            Console.Write("\n");
            var records = dataTable.AsEnumerable().Where(r => r.Field<string>("city") == city).OrderBy(r => r.Field<string>("FirstName")).ThenBy(r => r.Field<string>("LastName"));
            foreach (DataRow row in records)
            {
                foreach (DataColumn col in dataTable.Columns)
                {
                    Console.Write(row[col].ToString().PadRight(14));
                }
                Console.Write("\n");
            }
        }

        /// <summary>
        /// Method to Count number of contacts belonging to a type
        /// </summary>
        public void CountContactsByContactType()
        {
            var records = dataTable.AsEnumerable().GroupBy(x => x.Field<string>("ABookType")).Select(x => new { ABookType = x.Key, Count = x.Count() });
            foreach (var row in records)
            {
                Console.WriteLine(row.ABookType.PadRight(18) + row.Count);
            }
        }
    }
}
