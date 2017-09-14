using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat ssBrad = new Boat(2, 500, "black", 80.0d, .90d);
            ssBrad.Move();
            ssBrad.Move();
            Console.WriteLine("Boat " + ssBrad.GetDistanceTraveled());

            Automobile tesla = new Automobile(4, 22, 2, 5, 500, "yellow", 250d);
            tesla.Move();
            Console.WriteLine("Car " + tesla.GetDistanceTraveled());
        }
    }
}
