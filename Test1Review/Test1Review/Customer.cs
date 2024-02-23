using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1Review
{
    class Customer : Person
    {
        //Properties
        public int CustomerNumber;
        public bool OnMailingList;

        //initalizing name, address, phoneNumber from parent class 
        public Customer(int customerNumber, bool onMailingList, string name, string address, string phoneNumber) 
            : base(name, address, phoneNumber)
        {
            CustomerNumber = customerNumber;
            OnMailingList = onMailingList;
        }

        //samething as parent 
        public override string ToString()
        {
            return $"Customer Number: {CustomerNumber}, On Mailing List? {OnMailingList}";
        }
    }
}
