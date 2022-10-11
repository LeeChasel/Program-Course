using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5
{
    public class Triangle : Shape
    {
        public double Base
        {
            get; set;
        }
        public double Height
        {
            get; set;
        }
        public override double Area()
        {
            return Base * Height / 2;
        }
    }
}