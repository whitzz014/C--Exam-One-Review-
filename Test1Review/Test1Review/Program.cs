using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];

           // for (int i = 0; i < 3; i++)
           // {
                Console.WriteLine("Enter the Customer's Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the Customer's Address: ");
                string address = Console.ReadLine();

                Console.WriteLine("Enter the Customer's Phone Number: ");
                string pNumber = Console.ReadLine();

                Console.WriteLine("Enter the Customer Number: ");
                int cNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Would the customer like to sign up for the mailing list? (y/n): ");
                bool isOnMailingList = Console.ReadLine().Trim().ToLower() == "y";

                Console.Write("Enter the amount spent last year by the customer: ");
                int amountSpentLastYear = int.Parse(Console.ReadLine());

                customers[0] = new PreferredCustomer(name, address, pNumber, cNumber, isOnMailingList, amountSpentLastYear);
           // }

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }
        }
    }
}
