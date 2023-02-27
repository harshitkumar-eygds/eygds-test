using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eydemo17thfeb
{
    class vehicle
    {
        public void enginemaker()
        {
            Console.WriteLine("Engine of this vehicle is made in 1989");

        }
    }
    
    class day10classes
    {
        static void Main(string[] args)
        {
            vehicle obj = new vehicle();
            obj.enginemaker();

            scooter obj1 = new scooter();
            obj1.color();

            Console.ReadKey();

        }
    }
}
