using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1Review
{
     class PreferredCustomer : Customer
    {
        // Private backing field
        private double _discountLevel;

        //Properties 
        public int AmountSpent {get; set;}
      

        // Public property with a custom getter and setter
        public double DiscountLevel
        {
            get
            {
                //if to set custom discount amounts 
                if (AmountSpent >= 2000)
                {
                    return 0.1;
                }
                else if (AmountSpent >= 1500)
                {
                    return 0.07;
                }
                else if (AmountSpent >= 1000)
                {
                    return 0.06;
                }
                else if (AmountSpent >= 500)
                {
                    return 0.05;
                }
                else
                {
                    return 0;
                }
            }
        }

        public PreferredCustomer(string name, string address, string phoneNumber, int customerNumber, bool onMailingList, int amountSpent)
            : base( customerNumber,  onMailingList,  name,  address,  phoneNumber)
        {
            AmountSpent = amountSpent;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n Address: {Address}\n Phone Number: {PhoneNumber.ToPhoneNumber()}\n " +
                   $"Customer Number: {CustomerNumber}\n On Mailing List: {OnMailingList}\n " +
                   $"Customer Purchases: {Extension.ToCurrency(AmountSpent)}\n Discount Level: {DiscountLevel.ToPercentage()}"; ;
        }
    }
}
