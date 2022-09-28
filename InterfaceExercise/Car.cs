using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle
    {
        public bool hasSpoiler { get; set; }
        public string howManyDoors { get; set; }
        public string year { get; set; }
        public string milesCount { get; set; }
        public bool isDriveable { get; set; }
        public string mpg { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
        public string price { get; set; }
        public void VehicleMethodPrinter()
        {
            Console.WriteLine($"Does the car have a spoiler: {hasSpoiler}");
            Console.WriteLine($"How many doors does the car have: {howManyDoors}");
        }
    }
}
