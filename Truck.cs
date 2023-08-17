using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Price_Jacob
{
    internal class Truck : IAutomobile
    {
        //the constuctor for the Truck class
        public Truck(double speed, double weight, string lisencePlate)
        {

            //sets each property when the sedan object is made
            Speed = speed;
            LicensePlate = lisencePlate;
            Weight = weight;

            //checks the weight and changes the wheels accordingly
            if (Weight < 400) { Wheels = 8; }
            else { Wheels = 12; }

            //Prints a message to the console
            Console.WriteLine("Succesfully created Truck");
        }

        //a double property(Speed) with a public getter and private setter
        public double Speed { get; private set; }

        //an interger property(Wheels) with a public getter anda setter
        public int Wheels { get; set; }

        //a string property(LicensePlate) with a public getter and setter
        public string LicensePlate { get; set; }

        //a double property(Speed) with a public getter and setter
        public double Weight { get; set; }

        //The stringify method describing the object
        public void Stringify()
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate of {LicensePlate}.");
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
