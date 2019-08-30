using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Florida";
            customer.Id = 1;
            customer.FirstName = "Mike";  //setting 
            customer.LastName = "Sy";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "New York",
                FirstName = "Ashley",
                LastName = "Say"
            };

            Console.WriteLine(customer2.FirstName); //getting

            Console.ReadLine();
        }
    }
}
