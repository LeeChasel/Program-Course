using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5
{
    public class Product : Item
    {
        public double Price
        {
            get; set;
        }
        public double totalSales(int volumn)
        {
            return volumn * Price;
        }
    }
}