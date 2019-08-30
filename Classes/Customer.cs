using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        // Field defination 
        private string _firstName;
        public string FirstName
        {
            //Encapsulation
            get { return "Mrs." + _firstName; }
            set { _firstName = value; }
        }
        //Auto Property defination
        public int Id { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
