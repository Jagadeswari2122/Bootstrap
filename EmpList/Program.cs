using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpList
{
    class Program
    {
        static void Main(string[] args)
        {
            //string empDesig;
            //int emplid;
            //string ename;
            int empid;
            string empName;
            string empDesig;
            List<Employees> lt = new List<Employees>();
            int s = int.Parse(Console.ReadLine());
            switch (s)
            {
                case 1:
                    Console.WriteLine("How many employee Details you need to enter? ");
                    int details = int.Parse(Console.ReadLine());
                    for (int i = 0; i < details; i++)
                    {
                        Console.WriteLine("Enter EmployeeId ");
                        empid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter employee name ");
                        empName = Console.ReadLine();
                        Console.WriteLine("Enter employee designation ");
                        empDesig = Console.ReadLine();

                        lt.Add(new Employees(empid, empName, empDesig));
                    }
                    break;
                case 2:
                    Console.WriteLine("Details of Employees:");
                    Console.ReadLine();
                    List<Employees> id = lt.FindAll(op => op.Empid > 1);
                    foreach (Employees e in id)
                    {
                        Console.WriteLine(e.ToString());
                        Console.ReadKey();
                    }
                    break;
                case 3:
                    Console.WriteLine("updated details");
                    int up = int.Parse(Console.ReadLine());
                    if (up != empid)
                    {
                        //    List<Employees> u = new List<Employees>();
                        lt.Add(new Employees(empid, empName, empDesig));
                    }
                    break;
                case 4:
                         Console.WriteLine("delete the employee detailse");
                            int del = int.Parse(Console.ReadLine());
                            if(del==empid)
                            {

                              //  List<Employees> de = new List<Employees>();
                                lt.Remove(new Employees(empid, empName, empDesig));
                            }
                             break;
                             default:
                            Console.WriteLine("stop if needed");
                            break;
            }
        }
    }
}
