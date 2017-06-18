using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailApp.BAL
{
    public class Utilities
    {
        private const int PERCENTAGE_RATE_FOR_AMOUNT_BASED = 5;

        public static int GetPercentageDiscount(int billAmount, int percentage)
        {
            var result = (billAmount) - (billAmount * percentage / 100);
            return result;
        }

        public static int GetDiscountBasedOnAmount(int billAmount)
        {
            int numberOfHundred = billAmount / 100;
            var discount = numberOfHundred * PERCENTAGE_RATE_FOR_AMOUNT_BASED;
            return billAmount - discount;
        }
       
    }
}
