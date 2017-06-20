using RetailApp.Models;
using RetailApp.Repository;

namespace RetailApp.BAL.Models
{
    public class Customer: User, IDiscount
    {
        private int discount_rate = 5;

        /// <summary>
        /// Get Discount 5% for all customer for non grocery items and for all grocery item discount will be based 5% on every 100
        /// </summary>
        /// <param name="user">user details with bill amount</param>
        /// <returns></returns>
        public int GetDiscount(User user)
        {
            if (user.Product.Category == ProductCategory.Grocery)
            {
                return Utilities.GetDiscountBasedOnAmount(user.Product.BillAmount);
            }
            else
            {
                if (user.CustomerSinceYear < 2)
                {
                    discount_rate = 0;
                }

                return Utilities.GetPercentageDiscount(user.Product.BillAmount, discount_rate);
            }
        }
    }
}
