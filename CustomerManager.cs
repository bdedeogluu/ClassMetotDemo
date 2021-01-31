using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Customer is added. Properties of customer are:\n" + "Full Name: " + customer.CustomerName + " " + customer.CustomerSurname +
                "\nCustomer Id: " + customer.CustomerId + "\t Customer Phone: " + customer.CustomerPhone);
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Customer is deleted. Properties of customer were:\n" + "Full Name: " + customer.CustomerName + " " + customer.CustomerSurname +
                "\nCustomer Id: " + customer.CustomerId + "\t Customer Phone: " + customer.CustomerPhone);
        }
        public void ListCustomer(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer Id: " + customer.CustomerId);
                Console.WriteLine("Customer Full Name: " + customer.CustomerName + " " + customer.CustomerSurname);
                Console.WriteLine("Customer Phone: " + customer.CustomerPhone);
            }
        }
    }
}
