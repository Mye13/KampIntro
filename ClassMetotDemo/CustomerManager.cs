using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void addCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name +" "+ customer.LastName + " Eklendi");
        }

        public void listCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri Bilgileri: " + "Id:" +customer.Id + " " + "Name:"+customer.Name +" " +"LastName:" +customer.LastName);
        }
        public void deleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name +" "+ customer.LastName + " Silindi");
        }
    }
}
