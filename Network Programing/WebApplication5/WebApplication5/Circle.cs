using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5
{
    public class Circle
    {
        //兩種方式取得使用private變數，建構子與存取子
        private double radius;
        //建構子
        public Circle(double r)
        {
            radius = r;
        }

        /*特有的存取子 名字可自訂
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }*/

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public double Circumference()
        {
            return Math.PI * 2 * radius;
        }
    }
}