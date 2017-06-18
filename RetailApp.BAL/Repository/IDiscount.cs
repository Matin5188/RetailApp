using RetailApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailApp.Repository
{
    interface IDiscount
    {
        int GetDiscount(User user);
    }
}
