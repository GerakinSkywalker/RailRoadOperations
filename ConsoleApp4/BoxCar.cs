using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class BoxCar
    {
        public string NameOfCar { get; private set; }
        public string Destination { get; private set; }
        public string Receiver { get; private set; }
        public BoxCar(string nameOfCar, string destination, string receiver)
        {
            NameOfCar = nameOfCar;
            Destination = destination;
            Receiver = receiver;
        }
    }
}
