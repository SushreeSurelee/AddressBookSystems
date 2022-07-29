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
        public void AddContacts()
        {
            PersonInfo personInfo = new PersonInfo();
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
        public void DisplayContacts()
        {
            foreach (var data in listOfContacts)
            {
                Console.WriteLine("\nBelow is the details of person in Address Book.");
                Console.WriteLine("\nFirst name : "+data.FirstName+ "\nLast name : " + data.LastName+"\nCity : "+data.City+"\nState : "+data.State+"\nZip code : "+data.Zip+"\nMobile Number : "+data.MobileNum+"\nEmail ID : "+data.EmailID+ "\n");
            }
        }
        public void EditContacts()
        {
            Console.WriteLine("To edit the contact list enter the firstname of the person");
            string editName = Console.ReadLine();
            foreach(var data in listOfContacts)
            {
                if (editName == data.FirstName)
                {
                    Console.WriteLine("To edit contacts enter\n1.Lastname\n2.City\n3.State\n4.Zip\n5.Mobile Number\n6.Email ID");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            string lastName = Console.ReadLine();
                            data.LastName = lastName;
                            break;
                        case 2:
                            string city = Console.ReadLine();
                            data.City = city;
                            break;
                        case 3:
                            string state = Console.ReadLine();
                            data.State = state;
                            break;
                        case 4:
                            int zip = Convert.ToInt32(Console.ReadLine());
                            data.Zip = zip;
                            break;
                        case 5:
                            double mobileNum = Convert.ToDouble(Console.ReadLine());
                            data.MobileNum = mobileNum;
                            break;
                        case 6:
                            string emailId = Console.ReadLine();
                            data.EmailID = emailId;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid input as described in above line.");
                            break;
                    }
                }
            }
        }     
    }
}
