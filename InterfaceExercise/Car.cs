using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool HasAntiLock { get; set; }
        public string SeatMaterial { get; set; }
        private bool IsHatchBack { get; set; }

        public void Build()
        {
            Console.WriteLine("Getting user parameter input for car.");
            Console.Write("Enter the Year: ");
            int yearIn = int.Parse(Console.ReadLine());
            Console.Write("Enter the make: ");
            string makeIn = Console.ReadLine();
            Console.Write("Enter the model: ");
            string modelIn = Console.ReadLine();
            Console.Write("What material are the seats made with: ");
            string matIn = Console.ReadLine();
            Console.Write("Does this car have antilock brakes? Enter yes or no: ");
            string brakeIn = Console.ReadLine();
            VehicleInit(yearIn, makeIn, modelIn, matIn, SetBrakes(brakeIn.ToLower()));
            Console.Write("Does this car have a hatchback trunk? Enter yes or no: ");
            string hatchIn = Console.ReadLine();
            MakeHatchBack(SetHatch(hatchIn.ToLower()));

            Console.WriteLine("Building the car.");

        }

        public void GetInfo()
        {
            Console.WriteLine($"This is a {Year} {Make} {Model}.");
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

        public void VehicleInit(int year, string make, string model, string material, bool antiLock)
        {
            Year = year;
            Make = make;
            Model = model;
            SeatMaterial = material;
            HasAntiLock = antiLock;
        }

        public bool SetBrakes(string input)
        {
            if (input == "no") return false;
            else return true;
        }

        public bool SetHatch(string input)
        {
            if (input == "yes") return true;
            else return false;
        }

    }
}
