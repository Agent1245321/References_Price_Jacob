using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Price_Jacob
{
    internal class Sedan : IAutomobile
    { 
        //the constuctor 
        public Sedan(double speed)
        {
            
            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC-09";

            Console.WriteLine("Succesfully created Sedan");
        }
        public double Speed { get; private set; }
        public int Wheels { get; set;}

        public string LicensePlate { get; set; }

       public void Stringify()
        {
            Console.WriteLine($"The Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate of {LicensePlate}.");
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
