using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpList
{
    class Employees
    {
        int empid;
        string empName;
        string empDesig;
        public int Empid { get => empid; set => empid = value; }


        public Employees(int id, string name,string des)
        {
            this.empid = id;
            this.empName = name;
            this.empDesig = des;
        }

       
        public override string ToString()
        {
            return "\nEmpId : " + this.empid + "\nEmpNAME   : " + this.empName + "\nEmpDesignation : " + this.empDesig;
        }
    }
}
