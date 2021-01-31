using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1222;
            customer1.CustomerName = "John";
            customer1.CustomerSurname = "Angle";
            customer1.CustomerPhone = "23546";

            Customer customer2 = new Customer();
            customer2.CustomerId = 1224;
            customer2.CustomerName = "Micheal";
            customer2.CustomerSurname = "Key";
            customer2.CustomerPhone = "98654";

            Customer customer3 = new Customer();
            customer3.CustomerId = 1226;
            customer3.CustomerName = "Jiso";
            customer3.CustomerSurname = "Frost";
            customer3.CustomerPhone = "56423";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            CustomerManager customerManager = new CustomerManager();
            customerManager.ListCustomer(customers);
            customerManager.AddCustomer(customer1);
            customerManager.DeleteCustomer(customer2);
        }
    }
}
