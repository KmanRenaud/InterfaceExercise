using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle
    {
        public bool is4WDOrAWD { get; set; }
        public string howManySeats { get; set; }
        public string year { get; set; }
        public string milesCount { get; set; }
        public bool isDriveable { get; set; }
        public string mpg { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
        public string price { get; set; }
        public void VehicleMethodPrinter()
        {
            Console.WriteLine($"Is the SUV AWD or 4WD: {is4WDOrAWD}");
            Console.WriteLine($"How many seats does the SUV have: {howManySeats}");
        }
    }
}
