using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extension_Method_Library;

namespace Extension_Method_Example
{
    public static class ProductExtension
    {
        public static double GetDiscount(this Product product)
        {

            return product.ProductCost * product.DiscountPercentage / 100;
        }
    }
}
