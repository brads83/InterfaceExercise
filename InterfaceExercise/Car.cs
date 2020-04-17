using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{//In each of your car, truck, and suv classes

    /*Create 2 members that are specific to each class
     * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     * 
     */
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public string TrunkSize {get; set;}
        public bool automaticTransmission;
        public string WheelType { get; set; }
        public string Color { get; set; }
        public string InteriorFabric { get; set; }
        public string EngineSize { get; set; }
        public string Logo { get; set; }
        public string Slogan { get; set; }
    }
}
