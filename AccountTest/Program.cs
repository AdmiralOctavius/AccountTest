using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();

            myAccount.SetName("Isabella Bennett");

            Console.WriteLine("The name is:" + myAccount.GetName());

            Account hisAccount = new Account();

            hisAccount.SetName("Isaac Bennett");

            Console.WriteLine("The name is:" + hisAccount.GetName());

            Account theirAccount = new Account();

            theirAccount.SetName("Dr Bennett");

            Console.WriteLine("The name is:" + theirAccount.GetName());
        }
    }
}
