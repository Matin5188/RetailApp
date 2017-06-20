using RetailApp.BAL.Models;

namespace RetailApp.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CustomerSinceYear { get; set; }
        public Product Product { get; set; }
    }
}