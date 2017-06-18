using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RetailApp.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CustomerSinceYear { get; set; }
        public int BillAmount { get; set; }
        public bool IsGrocery { get; set; }        
    }
}