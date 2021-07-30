using application;
using System;

namespace BankingApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Batch batch = new Batch("Greenwich Bank");
            UserInterface.EnterNumberOfCustomer();

            int option;
            string customerId;

            UserInterface.ShowBatchInfo(batch);
            UserInterface.ShowMenuControl();
            do
            {
                option = UserInterface.EnterOption();
                switch (option)
                {
                    case 1://enter a list customer
                        int numberOfCustomer = UserInterface.EnterNumberOfCustomer();
                        UserInterface.EnterListCustomer();
                        for (int i = 0; i < numberOfCustomer; i++)
                        {

                            batch.AddCustomer(new Customer(
                                UserInterface.EnterCustomerId(),
                                UserInterface.EnterCustomerFullName(),
                                UserInterface.EnterCustomerBalance()
                                ));
                        }

                        break;
                    case 2:  //add
                        batch.AddCustomer(new Customer(
                            UserInterface.EnterCustomerId(),
                            UserInterface.EnterCustomerFullName(),
                            UserInterface.EnterCustomerBalance())
                            );
                        UserInterface.ShowBatchInfo(batch);
                        break;
                    case 3:  //find
                        customerId = UserInterface.EnterCustomerId();
                        if (batch.FindCustomerById(customerId) != null)
                        {
                            UserInterface.ShowCustomerInfo(batch.FindCustomerById(customerId));
                        }
                        else
                        {
                            UserInterface.NotFound();
                        }
                        break;
                    case 4:   //edit balance 
                        customerId = UserInterface.EnterCustomerId();
                        if (batch.FindCustomerById(customerId) == null)
                        {
                            UserInterface.NotFound();
                        }
                        else
                        {
                            string customerName = UserInterface.EnterCustomerFullName();
                            double customerBalance = UserInterface.EnterCustomerBalance();
                            batch.EditCustomerById(customerId, customerName, customerBalance);
                            UserInterface.Done();
                        }
                        break;
                    case 5: //show all customer info
                        UserInterface.ShowAllCustomerInfo();
                        UserInterface.ShowBatch(batch);
                        break;
                    case 6: //exit
                        UserInterface.ExitProgram(option);
                        break;
                    default:
                        UserInterface.EnterOptionAgain();
                        break;
                }
            } while (option != 6);

            Console.ReadLine();
        }
    }
}
