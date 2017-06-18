using RetailApp.BAL;
using RetailApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RetailApp.Models
{
    public class Employee : User, IDiscount
    {
        private const int DISCOUNT_RATE = 30;        

        /// <summary>
        /// Get Discount 30% for all employees for  non grocery items and for all grocery item discount will be based 5% on every 100
        /// </summary>
        /// <param name="user">user details with bill amount</param>
        /// <returns></returns>
        public int GetDiscount(User user)
        {
            if (user.IsGrocery)
            {
                return Utilities.GetDiscountBasedOnAmount(user.BillAmount);
            }
            else
            {
                return Utilities.GetPercentageDiscount(user.BillAmount, DISCOUNT_RATE);
            }
        }
    }
}