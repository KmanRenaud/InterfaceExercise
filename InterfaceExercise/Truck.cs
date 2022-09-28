using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle
    {
        public bool canCarryTrailer { get; set; }
        public bool hasBackSlidingWindow { get; set; }
        public string year { get; set; }
        public string milesCount { get; set; }
        public bool isDriveable { get; set; }
        public string mpg { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
        public string price { get; set; }
        public void VehicleMethodPrinter()
        {
            Console.WriteLine($"Can the truck carry a trailer: {canCarryTrailer}");
            Console.WriteLine($"Does the truck have a back sliding window: {hasBackSlidingWindow}");
        }
    }
}
