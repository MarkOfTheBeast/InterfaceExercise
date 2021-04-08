using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public int Year { get; set; }
        public string SeatMaterial { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool HasAntiLock { get; set; }
        public void GetInfo();

        public void VehicleInit(int year, string make, string model, string material, bool antiLock);

        public void Build();
    }


}
