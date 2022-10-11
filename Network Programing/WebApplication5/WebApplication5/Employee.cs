using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5
{
    public class Employee
    {
        public string Name
        {
            get; set;
        }
        public bool Gender
        {
            get; set;
        }
        //產生employee物件時，自動產生skills動態陣列
        public List<string> skills = new List<string>();
        public string getInfo()
        {
            string r = "";
            if (Gender)
            {
                r = r + "Mr. ";
            } else
            {
                r = r + "Miss ";
            }

            r = r + Name + "<br/>";
            foreach (string i in skills)
            {
                r = r + i + "<br/>";
            }

            return r;
        }
    }
}