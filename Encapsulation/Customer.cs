using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Customer
    {
        public string FirstName;  //Bu şekilde tanımlarsan field tanımlamış olursun.
        public int Id { get; set; } // -> Bu şekilde tanımlarsan property tanımlamış olursun.
       // public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
