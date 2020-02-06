using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFactory
{
    interface Ifactory
    {
        void manufacture(int cnt);
    }//create product class
    class Bike : Ifactory
    {
        public void  manufacture(int cnt)
        {
            Console.WriteLine("bike Manufacturing no" + cnt);
        }
    }//create product class
    class Car : Ifactory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("Car Manufacturing no" + cnt);
        }
    }
        abstract class VehicleFactory
        {
        public abstract Ifactory genVehicle(string type);
        }
    class Concrete:VehicleFactory
    {
        public override Ifactory genVehicle(string type)
        {
            //    switch(type)
            //    {
            //        case "Bike":return new Bike();break;
            //        case "Car": return new Car(); break;
            //        default:Console.WriteLine("factory cannot produce this product");
            //            return
            //            break;
            if (type == "Bike") return new Bike();
            else
                return new Car();
            //throw new NotImplementedException();


        }
        //{
        //   
        //    Console.WriteLine()
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
        VehicleFactory o = new Concrete();
        //o.genVehicle("Bike");
        Ifactory myVehicle = o.genVehicle("Bike");
        myVehicle.manufacture(5);
        myVehicle = o.genVehicle("Car");
        myVehicle.manufacture(4);
        }
    }
}
