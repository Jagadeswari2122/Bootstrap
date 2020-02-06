using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("acc no:");
            int accno = int.Parse(Console.ReadLine());
            Console.WriteLine("Name:");
           string cname =Console.ReadLine();
            Console.WriteLine("account type:");
            string acctype= Console.ReadLine();
            AccDetails a1 = new AccDetails(accno,cname,acctype);
            Console.WriteLine("transaction type:");
            Console.WriteLine("enter amount to deposit");

        }
    }
}
