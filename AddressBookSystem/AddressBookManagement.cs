﻿using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class AddressBookManagement
    {
        private List<PersonInfo> listOfContacts = new List<PersonInfo>();
        Dictionary<string, List<PersonInfo>> listOfBooks = new Dictionary<string, List<PersonInfo>>();
        public void AddContacts(string addressBookName,int numOfContacts)
        {
            listOfContacts.Clear();
            PersonInfo personInfo = new PersonInfo();
            int count = 0;
            while (true)
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
                count++;
                if(count == numOfContacts)
                {
                    listOfBooks.Add(addressBookName, listOfContacts);
                    break;
                }
            }
        }
        public void DisplayContacts()
        {
            foreach (PersonInfo data in listOfContacts)
            {
                Console.WriteLine("\nBelow is the details of person in Address Book.");
                Console.WriteLine("\nFirst name : "+data.FirstName+ "\nLast name : " + data.LastName+"\nCity : "+data.City+"\nState : "+data.State+"\nZip code : "+data.Zip+"\nMobile Number : "+data.MobileNum+"\nEmail ID : "+data.EmailID+ "\n");
            }
        }
        public void EditContacts()
        {
            Console.WriteLine("To edit the contact list enter the firstname of the person");
            string editName = Console.ReadLine();

            for(int i=0;i<listOfContacts.Count;i++)
            {
                PersonInfo data = listOfContacts[i];
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
                else
                {
                    Console.WriteLine("Please enter the valid name.\n");
                }
            }
        }
        public void DeletePerson()
        {
            Console.WriteLine("To delete the contact list enter the firstname of the person");
            string deleteName = Console.ReadLine();
            for (int i = 0; i < listOfContacts.Count; i++)
            {
                PersonInfo data = listOfContacts[i];
                if(data.FirstName==deleteName)
                {
                    listOfContacts.Remove(data);
                    Console.WriteLine("You have sucessfully deleted {0}'s contact.\n",deleteName);
                }
                else
                {
                    Console.WriteLine("Please enter the valid name which is present inside of the address book.\n");
                }
            }
        }
        
    }
}
