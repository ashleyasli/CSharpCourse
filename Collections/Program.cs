using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "masa");
            dictionary.Add("computer", "bilgisayar");

            //Console.WriteLine(dictionary["table"]);
            //Console.WriteLine(dictionary["glass"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }

           // Console.WriteLine(dictionary.ContainsKey("glass"));
            //Console.WriteLine(dictionary.ContainsKey("table"));

            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("New York");
            cities.Add("Florida");

            Console.WriteLine(cities.Contains("Florida"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }


            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Debra" });
            //customers.Add(new Customer { Id = 2, FirstName = "Mike" });

            List<Customer> customers = new List<Customer>
            {
                new Customer {Id = 1, FirstName = "Ashley"},
                new Customer {Id = 2, FirstName = "Jo"}
            };


            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Sally"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer {Id = 4, FirstName = "Mike"},
                new Customer {Id = 5, FirstName = "Marry"}
            });

            Console.WriteLine(customers.Contains(customer2));

           // customers.Clear();

            var index = customers.IndexOf(customer2);
            Console.WriteLine("Index : {0}", index);

            customers.Add(customer2);
            var index2 = customers.LastIndexOf(customer2);
            Console.WriteLine("Index : {0}", index2);

            customers.Insert(0, customer2);

            //customers.Remove(customer2);
            //customers.Remove(customer2);
            //customers.Remove(customer2);
            //customers.RemoveAll(c => c.FirstName == "Sally");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            var count = customers.Count;
            Console.WriteLine("Count : {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("New York");
            cities.Add("Seattle");


            cities.Add("Florida");
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            //Console.WriteLine(cities[2]);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
