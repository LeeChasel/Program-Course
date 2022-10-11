using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6
{
    public class Employee
    {
        public string Name { get; set; }
        public bool Gender { get; set; }
        //List為動態陣列的類別
        //Skills為資料類型為List的類別，沒new出物件的話任何操作都是null，沒有記憶體空間
        public List<string> Skills { get; set; }

        public string getInfo()
        {
            string r = "";
            if (this.Gender)
            {
                r = r + "Mr. ";
            }
            else
            {
                r = r + "Miss ";
            }

            r = r + this.Name + "<br/>";
            foreach (string s in this.Skills)
            {
                r = r + s + "<br/>";
            }
            return r;
        }
    }
}