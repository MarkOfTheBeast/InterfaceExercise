using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var Car1 = new Car();
            Car1.CompanyInit("Mazda", "commuter");
            Car1.VehicleInit(2021, "3 Hatchback", "fabric", true);
            Car1.MakeHatchBack(true);
            Car1.GetInfo();

            var Car2 = new Car();
            Car2.CompanyInit("Lexus", "luxury");
            Car2.VehicleInit(2021, "ES Hybrid", "leather", true);
            Car2.MakeHatchBack(false);
            Car2.GetInfo();

            var Truck1 = new Truck();
            Truck1.CompanyInit("Dodge", "high performance");
            Truck1.VehicleInit(2010, "Ram", "fabric", false);
            Truck1.TruckInit(false, false);
            Truck1.GetInfo();

            var Truck2 = new Truck();
            Truck2.CompanyInit("Ford", "affordable");
            Truck2.VehicleInit(2020, "F-150", "fabric", true);
            Truck2.TruckInit(true, true);
            Truck2.GetInfo();

            var SUV1 = new SUV();
            SUV1.CompanyInit("Mazda", "commuter");
            SUV1.VehicleInit(2020, "CX-9", "fabric", true);
            SUV1.SUVInit(false, 3);
            SUV1.GetInfo();

            var SUV2 = new SUV();
            SUV2.CompanyInit("Toyota", "commuter");
            SUV2.VehicleInit(2021, "Rav4", "fabric", true);
            SUV2.SUVInit(true, 2);
            SUV2.GetInfo();



        }

        

    }
}
