using System;

namespace application
{
    class UserInterface
    {
        public static void ExampleInfo(Customer customer)
        {

            Console.WriteLine("===================================");

            customer.CustomerShowInfo();

            Console.WriteLine("===================================");

            Console.WriteLine("Please enter customer data as sample form!!!");

            Console.Write("Enter number of customer you want to add: ");

        }

        public static void ShowCustomerInfo(Customer customer)
        {
            customer.CustomerShowInfo();
            Console.WriteLine("===================================");
        }

        public static void ShowBatchInfo(Batch batch)
        {
            Console.WriteLine($"Batch name: {batch.Name}");
            Console.WriteLine($"Number customer in batch: {batch.Customers.Count} customer");

        }

        public static string EnterCustomerId()
        {
            Console.Write("Please enter customer ID: ");
            return Console.ReadLine();
        }
        public static string EnterCustomerFullName()
        {
            Console.Write("Please enter customer Full Name: ");
            return Console.ReadLine();
        }
        public static double EnterCustomerBalance()
        {
            Console.Write("Please enter customer Balance: ");
            return double.Parse(Console.ReadLine());
        }

        public static void ShowMenuControl()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("||Please choose your command control below||");
            Console.WriteLine("||1. Add new customer                     ||");
            Console.WriteLine("||2. Find customer by ID                  ||");
            Console.WriteLine("||3. Edit customer balance by ID          ||");
            Console.WriteLine("||4. Show all info customer               ||");
            Console.WriteLine("||5. Exit                                 ||");
            Console.WriteLine("============================================");
        }

        public static void ShowEditOptionControl()
        {
            Console.WriteLine("What do you want to edit?");
            Console.WriteLine("1. Edit Name");
            Console.WriteLine("2. Edit balance");
        }

        public static int EnterOption()
        {
            Console.Write("Enter your option:");
            return int.Parse(Console.ReadLine());
        }

        public static void ShowBatch(Batch batch)
        {
            Console.WriteLine($"Batch: {batch.Name}");
            Console.WriteLine($"Number of customer: {batch.Customers.Count}");
            Console.WriteLine("=========================");
            foreach (var customer in batch.Customers)
            {
                customer.CustomerShowInfo();
                Console.WriteLine("===============");
            }
        }
        public static void ExitProgram(int option)
        {
            Console.WriteLine("Exit the program.");
            option = 6;
        }
        public static void NotFound()
        {
            Console.WriteLine("Customer not found");
        }
        public static void Done()
        {
            Console.WriteLine("Done");
        }
        public static void EnterListCustomer()
        {
            Console.WriteLine("Enter List Customer by ID, Name, Balance: ");    
        }
        public static void ShowAllCustomerInfo()
        {
            Console.WriteLine("===================================");

            Console.WriteLine("All customer info");
        }
        public static void EnterOptionAgain()
        {
            Console.WriteLine("please enter option again: ");

        }
        public static int EnterNumberOfCustomer()
        {
            Console.Write("Enter Number of Customer: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
