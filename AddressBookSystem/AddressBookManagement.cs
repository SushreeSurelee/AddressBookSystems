using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBookManagement
    {
        List<PersonInfo> listOfContacts = new List<PersonInfo>();

        public List<PersonInfo> AddContacts(int numOfContacts)
        {
            PersonInfo personInfo = new PersonInfo();
            for (int i = 0; i < numOfContacts; i++)
            {
                Console.Write("Enter First Name: ");
                personInfo.FirstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                personInfo.LastName = Console.ReadLine();
                Console.Write("Enter City: ");
                personInfo.City = Console.ReadLine();
                Console.Write("Enter State: ");
                personInfo.State = Console.ReadLine();
                Console.Write("Enter Zip: ");
                personInfo.Zip = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Phone Number: ");
                personInfo.MobileNum = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Email ID: ");
                personInfo.EmailID = Console.ReadLine();
                listOfContacts.Add(personInfo);
            }
            return listOfContacts;
        }
        
    }
}
