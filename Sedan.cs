using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Price_Jacob
{
    internal class Sedan : IAutomobile
    { 
        //the constuctor for the Sedan class
        public Sedan(double speed)
        {
            
            //sets each property when the sedan object is made
            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC-09";

            //Prints a message to the console
            Console.WriteLine("Succesfully created Sedan");
        }

        //a double property(Speed) with a public getter and a private setter
        public double Speed { get; private set; }

        //an interger property(Wheels) with a public getter and a setter
        public int Wheels { get; set;}

        //a string property(LicensePlate) with a public getter and a setter
        public string LicensePlate { get; set; }

        //The stringify method describing the object
       public void Stringify()
        {
            Console.WriteLine($"The Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate of {LicensePlate}.");
        }

        //2 methods to raise and lower the speed property
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
