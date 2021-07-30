using System;

namespace application
{
    class Customer
    {
        public double Balance;

        public string ID;

        public string Name;

        public Customer()
        {
            ID = "N/A";

            Name = "N/A";

            Balance = 0.50;
        }

        public Customer(string id, string name, double balance)
        {
            ID = id;

            Name = name;

            Balance = balance;
        }

        public void CustomerShowInfo()
        {

            Console.WriteLine($"ID of customer: {ID}");
            Console.WriteLine($"Name of customer: {Name}");
            Console.WriteLine($"Balance of customer: {Balance}$");

        }
    }
}
