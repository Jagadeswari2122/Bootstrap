using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    class AccDetails
    {
         int accno;
         string cname;
         string acctype;
         string transtype;
         double amount;
        double bal;
        int value;

        //public int Accno { get => accno; set => accno = value; }
        //public int Amount { get => amount; set => amount = value; }
        //public int Bal { get => bal; set => bal = value; }
        //public string Trasctype { get => trasctype; set => trasctype = value; }
        public AccDetails(int accno, string name,string acctype)
        {
            this.accno = accno;
            this.cname = cname;
            this.acctype = acctype;
        }

        public void Credit(double amount)
        {
            this.transtype = "D";
            this.bal += amount;
            //Console.WriteLine("enter the amount");
            //amount = bal + value;
            //Console.WriteLine("Transaction is deposited");
        }
        public void Debit(double amount)
        {
            this.transtype = "W";
            this.bal += amount;
            //amount = bal - value;
            //Console.WriteLine("Transaction is withdrawal");
        }

    }
}
