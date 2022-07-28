using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class PersonInfo
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        private int _mobileNum { get; set; }
        public string emailID { get; set; }
        public int MobileNum
        {
            get
            {
                return _mobileNum;
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
                    _mobileNum = value;
                }
            }
        }
    }
}
