using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : ICompany, IVehicle
    {
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
        public int Year { get; set; }
        public string SeatMaterial { get; set; }
        public string Model { get; set; }
        public bool HasAntiLock { get; set; }
        private bool IsHatchBack { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"This is a {Year} {CompanyName} {Model}.");
            Console.WriteLine($"This company specializes in making {CompanyType} vehicles.");
            Console.WriteLine($"It has {SeatMaterial} seats.");
            Console.WriteLine(GetAntiLock());
            Console.WriteLine(GetTrunkType());
            Console.WriteLine();
        }

        private string GetAntiLock()
        {
            return HasAntiLock ? "It has antilock brakes." : "It doesn't have antilock brakes.";
        }

        private string GetTrunkType()
        {
            return IsHatchBack ? "It has a hatchback trunk." : "It has a regular trunk.";
        }

        public void MakeHatchBack(bool input)
        {
            IsHatchBack = input;
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
    }
}
