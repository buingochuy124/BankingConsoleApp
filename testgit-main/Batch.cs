using System;
using System.Collections.Generic;
using System.Linq;

namespace application
{
    class Batch
    {
        public string Name;

        public List<Customer> Customers;

        public Batch(string name)
        {
            Name = name;
            Customers = new List<Customer>();
        }

        public Customer FindCustomerById(string id)
        {
            var customerInBatch = Customers.SingleOrDefault(c => c.ID.Equals(id));
            return customerInBatch;
        }

        public bool AddCustomer(Customer customer)
        {
            if (FindCustomerById(customer.ID) != null)
            {
                return false;
            }

            Customers.Add(customer);
            return true;
        }


        public bool DeleteCustomerById(string id)
        {
            var customerInBatch = FindCustomerById(id);

            if (customerInBatch == null) return false;

            Customers.Remove(customerInBatch);
            return true;
        }


        public int EnterOption()
        {
            Console.Write("Enter your option: ");
            return int.Parse(Console.ReadLine());
        }

        public Customer EditCustomerById(string id, string name, double balance)
        {

            var customerInBatch = FindCustomerById(id);

            if (FindCustomerById(id) == null)
            {
                return null;
            }
            customerInBatch.Balance = balance;

            customerInBatch.Name = name;

            return customerInBatch;
        }

    }
}
