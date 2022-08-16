using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Ali";
            customer1.LastName = "Aslan";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Ahmet";
            customer2.LastName = "Göbekli";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Sadık";
            customer3.LastName = "Turan";

            CustomerManager customerManager = new CustomerManager();
            customerManager.addCustomer(customer1);
            customerManager.deleteCustomer(customer2);
            customerManager.listCustomer(customer3);

            Console.WriteLine("----------Müşteriler----------");
            Customer[] customers = new Customer[] 
            {customer1, customer2, customer3 };
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name);
            }

            

        }
    }
}
