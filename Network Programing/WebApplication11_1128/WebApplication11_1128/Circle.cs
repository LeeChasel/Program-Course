using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication11_1128
{
    public class Circle
    {
        public int radius { get; set; }
        public double Area(Func<int, double> area)
        {
            return area(radius);
        }
    }
}