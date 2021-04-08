using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    static class VehicleFactory
    {
        public static IVehicle GetVehicle(string input)
        {
            switch (input.ToLower())
            {
                case "car":
                    return new Car();

                case "truck":
                    return new Truck();

                case "suv":
                    return new SUV();

                default:
                    return new Car();


            }
        
        
        }



    }
}
