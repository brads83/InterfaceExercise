using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car kia = new Car();
            kia.Logo = "KIA";
            kia.TrunkSize = "small";
            kia.EngineSize = "four cylinder";
            kia.WheelType = "aluminum";
            kia.InteriorFabric = "cloth";
            kia.Slogan = "We wanna see ya in a Kia";
            kia.Color = "white";
            kia.automaticTransmission = true;

            Truck dodge = new Truck();
            dodge.BedSize = "six feet";
            dodge.Color = "black";
            dodge.EngineSize = "eight cylinder";
            dodge.fourWheelDrive = true;
            dodge.InteriorFabric = "cloth";
            dodge.Logo = "DODGE";
            dodge.Slogan = "Guts. Glory. Ram";
            dodge.WheelType = "chrome";

            Suv lexus = new Suv();
            lexus.CargoHoldSize = "small";
            lexus.Color = "gold";
            lexus.EngineSize = "six cylinder";
            lexus.InteriorFabric = "leather";
            lexus.Logo = "LEXUS";
            lexus.Slogan = "The relentless pursuit of perfection";
            lexus.thirdRow = true;
            lexus.WheelType = "polished chrome";

            var vehicleList = new List<IVehicle>();

            vehicleList.Add(kia);
            vehicleList.Add(dodge);
            vehicleList.Add(lexus);

            foreach(var vehicle in vehicleList)
            {
                Console.WriteLine($"Color: {vehicle.Color} WheelType: {vehicle.WheelType} Interior: {vehicle.InteriorFabric} Engine Size: {vehicle.EngineSize}");
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
        }
    }
}
