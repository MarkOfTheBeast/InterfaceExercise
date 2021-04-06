using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle, ICompany
    {
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
        public int Year { get; set; }
        public string SeatMaterial { get; set; }
        public string Model { get; set; }
        public bool HasAntiLock { get; set; }

        public bool HasHitch { get; set; }

        public int SeatRows { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"This is a {Year} {CompanyName} {Model}.");
            Console.WriteLine($"This company specializes in making {CompanyType} vehicles.");
            Console.WriteLine($"It has {SeatMaterial} seats.");
            Console.WriteLine(GetAntiLock());
            Console.WriteLine(GetHitch());
            Console.WriteLine($"It has {SeatRows} rows of seats.");
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

        public void SUVInit(bool hitch, int rows)
        {
            HasHitch = hitch;
            SeatRows = rows;
        }

    }
}
