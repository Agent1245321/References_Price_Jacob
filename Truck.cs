using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Price_Jacob
{
    internal class Truck : IAutomobile
    {
       public Truck(double speed, double weight, string lisencePlate)
        {
           
            Speed = speed;
            LicensePlate = lisencePlate;
            Weight = weight;

            if (Weight < 400) { Wheels = 8; }
            else { Wheels = 12; }
            Console.WriteLine("Succesfully created Truck");
        }
        public double Speed { get; private set; }
        public int Wheels { get; set; }

        public string LicensePlate { get; set; }

        public double Weight { get; set; }

        public void Stringify()
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate of {LicensePlate}.");
        }

        public void SpeedUp()
        {
            Console.WriteLine("Speeding up...");
            Speed += 5;
        }

        public void SlowDown()
        {
            Console.WriteLine("Slowing down...");
            Speed -= 5;
        }
    }
}
