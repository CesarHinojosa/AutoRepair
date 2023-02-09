using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.AutoRepair.UI
{
    public class CustomerCollection : List<Customer>
    {
        public void LoadTestCustomers()
        {

            //doing it like this you are able to use the whole thing and copy and paste
            Customer customer;
            customer = new Customer();
            customer.FirstName = "Bob";
            customer.LastName = "Kraus";
            customer.PhoneNumber = "1234567890";
            Add(customer);

            customer = new Customer();
            customer.FirstName = "Cesar";
            customer.LastName = "Hinojosa";
            customer.PhoneNumber = "1234567890";
            Add(customer);

            customer = new Customer();
            customer.FirstName = "Patrick";
            customer.LastName = "Barany";
            customer.PhoneNumber = "(920)481-5911";
            Add(customer);
        }

    }
}
