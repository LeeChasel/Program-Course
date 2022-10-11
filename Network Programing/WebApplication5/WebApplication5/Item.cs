using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5
{
    public class Item
    {
        public string Name
        {
            get; set;
        }
        public string ID
        {
            get; set;
        }
        public string fullName()
        {
            return ID + "_" + Name;
        }
    }
}