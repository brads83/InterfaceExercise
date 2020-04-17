using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{ //In your IVehicle

    /* Create 4 members that Car, Truck, & SUV all have in common.
     * Example: All vehicles have a number of wheels... for now..
     */
    public interface IVehicle
    {
        public string WheelType { get; set; }
        public string Color { get; set; }
        public string InteriorFabric { get; set; }
        public string EngineSize { get; set; } 
    }
}
