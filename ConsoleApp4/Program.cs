using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BoxCar> boxes = new List<BoxCar>();
            boxes.Add(new BoxCar("Box Car 1", "Houston", "FedEx"));
            boxes.Add(new BoxCar("Box Car 2", "Chicago", "FedEx"));
            boxes.Add(new BoxCar("Box Car 3", "Houston", "UPS"));
            boxes.Add(new BoxCar("Box Car 4", "LA", "Old Dominion"));
            boxes.Add(new BoxCar("Box Car 5", "LA", "FedEx"));
            boxes.Add(new BoxCar("Box Car 6", "Houston", "Old Dominion"));

            var classificationTracks = new Dictionary<string, int>();
            classificationTracks.Add("Houston", 1);
            classificationTracks.Add("Chicago", 2);
            classificationTracks.Add("LA", 3);

            var receivers = new Dictionary<string, int>();
            receivers.Add("UPS", 1);
            receivers.Add("FedEx", 2);
            receivers.Add("Old Dominion", 3);

            boxes.Sort(new BoxCarComparer(classificationTracks, receivers));

            Console.WriteLine("Classification Track\tName of Car\tDestination\tReceiver");
            foreach (var box in boxes)
            {
                Console.WriteLine("{0}\t\t\t{1}\t{2}\t\t{3}", 
                    classificationTracks[box.Destination], 
                    box.NameOfCar, 
                    box.Destination, 
                    box.Receiver);
            }
        }
    }
}
