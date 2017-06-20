namespace RetailApp.BAL.Models
{
    public class Product
    {
        public string ProductCode { get; set; }
        public int BillAmount { get; set; }
        public ProductCategory Category { get; set; }
    }

    public enum ProductCategory
    {
        Grocery,
        NonGrocery
    }
}
