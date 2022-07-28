using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBookManagement addressBookManagement = new AddressBookManagement();

            Console.WriteLine("Please choose number as shown below\n1:Add Contacts.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter how many contacts you wish to add in AddressBook.");
                    int numOfContacts = Convert.ToInt32(Console.ReadLine());
                    addressBookManagement.AddContacts(numOfContacts);
                    break;
            }
            Console.ReadLine();
        }
    }
}
