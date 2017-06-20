using RetailApp.Models;
using RetailApp.Repository;

namespace RetailApp.BAL.Models
{
    public class Affiliate: User, IDiscount
    {
        private const int DISCOUNT_RATE = 10;

        /// <summary>
        /// Get Discount 10% for all affiliate for non grocery items and for all grocery item discount will be based 5 on every 100
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
                return Utilities.GetPercentageDiscount(user.Product.BillAmount, DISCOUNT_RATE);
            }
        }
    }
}
