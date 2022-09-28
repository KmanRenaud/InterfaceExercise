using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class VehicleLister : IVehicle
    {
        public string name { get; set; }
        public string logo { get; set; }
        public string price { get; set; }
        public string year { get; set; }
        public string milesCount { get; set; }
        public bool isDriveable { get; set; }
        public string mpg { get; set; }
    }
}
