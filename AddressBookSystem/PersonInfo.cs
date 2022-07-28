using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class PersonInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        private double _MobileNum { get; set; }
        public string EmailID { get; set; }
        public double MobileNum
        {
            get
            {
                return _MobileNum;
            }
            set
            {
                if (value < 10)
                {
                    Console.WriteLine("Enter mobile number consist of 10 digits.");
                    return;
                }
                else
                {
                    _MobileNum = value;
                }
            }
        }
    }
}
