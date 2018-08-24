using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTest
{
    public class Account
    {
        private string name;
        private decimal balance;
        public string Name {
            get { return name; }

            set { name = value; }
        }

        public Account()
        {
            balance = 0;
            Name = "Unknown";
        }
       /*
        *public string GetName()
        {
            return name;
        }

        public void SetName(string inName)
        {
            name = inName;
        }
        */
    }
}
