using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System\n");
            AddressBookManagement addressBookManagement = new AddressBookManagement();
            int option;
            do
            {
                Console.WriteLine("Please choose number as shown below to execute that task\n1:Add Contacts.\n2:Display Contacts\n3:Edit Contacts.\n4:Delete Contact.\n5:Exit");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please enter unique address book name");
                        string addressBookName = Console.ReadLine();
                        Console.WriteLine("Please enter how many contact do you want to add under address book?");
                        int numOfContacts = Convert.ToInt32(Console.ReadLine());
                        addressBookManagement.AddContacts(addressBookName,numOfContacts);
                        break;
                    case 2:
                        addressBookManagement.DisplayContacts();
                        break;
                    case 3:
                        addressBookManagement.EditContacts();
                        break;
                    case 4:
                        addressBookManagement.DeletePerson();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (option != 5);
        }
    }
}
