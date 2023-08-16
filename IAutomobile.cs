using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is the Iautomobile Interface, it contains 3 properties and one method
namespace References_Price_Jacob
{
    internal interface IAutomobile
    {
        double Speed { get;}
        int Wheels { get; }
        string LicensePlate { get; }
        
        public void Stringify() { }
    }
}
