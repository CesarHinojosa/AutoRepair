using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.AutoRepair.UI
{


    
    //class is a collection of properties 
    public class Customer
    {
        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        public string PhoneNumber { get; set; } = "";

        //read only property 
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        //methods
        public override string ToString()
        {
            return FullName;
        }
    }
}
