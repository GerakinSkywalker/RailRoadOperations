using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class BoxCarComparer : IComparer<BoxCar>
    {
        private Dictionary<string, int> Destinations { get; set; }
        private Dictionary<string, int> Receivers { get; set; }

        public BoxCarComparer(Dictionary<string,int> destinations, Dictionary<string, int> receivers)
        {
            Destinations = destinations;
            Receivers = receivers;
        }

        public int Compare(BoxCar x, BoxCar y)
        {
            var destinationComparison = Destinations[x.Destination].CompareTo(Destinations[y.Destination]);
            if (destinationComparison == 0)
            {
                return Receivers[x.Receiver].CompareTo(Receivers[y.Receiver]);
            }
            return destinationComparison;
        }
    }
}
