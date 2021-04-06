using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : ICompany, IVehicle
    {
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
        public int Year { get; set; }
        public string SeatMaterial { get; set; }
        public string Model { get; set; }
        public bool HasAntiLock { get; set; }

        public bool HasHitch { get; set; }

        public bool HasLiner { get; set; }


        public void GetInfo()
        {
            Console.WriteLine($"This is a {Year} {CompanyName} {Model}.");
            Console.WriteLine($"This company specializes in making {CompanyType} vehicles.");
            Console.WriteLine($"It has {SeatMaterial} seats.");
            Console.WriteLine(GetAntiLock());
            Console.WriteLine(GetHitch());
            Console.WriteLine(GetLiner());
            Console.WriteLine();
        }

        private string GetAntiLock()
        {
            return HasAntiLock ? "It has antilock brakes." : "It doesn't have antilock brakes.";
        }

        private string GetHitch()
        {
            return HasHitch ? "It has a hitch." : "It doesn't have a hitch.";
        }

        private string GetLiner()
        {
            return HasLiner ? "It has a bed liner." : "It doesn't have a bed liner.";
        }

        public void CompanyInit(string name, string type)
        {
            CompanyName = name;
            CompanyType = type;
        }

        public void VehicleInit(int year, string model, string material, bool antiLock)
        {
            Year = year;
            Model = model;
            SeatMaterial = material;
            HasAntiLock = antiLock;
        }

        public void TruckInit(bool hitch, bool liner)
        {
            HasHitch = hitch;
            HasLiner = liner;
        }
    }
}
