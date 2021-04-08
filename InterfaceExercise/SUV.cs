using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool HasAntiLock { get; set; }
        public string SeatMaterial { get; set; }

        public bool HasHitch { get; set; }

        public int SeatRows { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"This is a {Year} {Make} {Model}.");
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

        public void VehicleInit(int year, string make, string model, string material, bool antiLock)
        {
            Year = year;
            Make = make;
            Model = model;
            SeatMaterial = material;
            HasAntiLock = antiLock;
        }

        public void SUVInit(bool hitch, int rows)
        {
            HasHitch = hitch;
            SeatRows = rows;
        }

        public void Build()
        {
            Console.WriteLine("Getting user parameter input for SUV.");
            Console.Write("Enter the Year: ");
            int yearIn = int.Parse(Console.ReadLine());
            Console.Write("Enter the make: ");
            string makeIn = Console.ReadLine();
            Console.Write("Enter the model: ");
            string modelIn = Console.ReadLine();
            Console.Write("What material are the seats made with: ");
            string matIn = Console.ReadLine();
            Console.Write("Does this SUV have antilock brakes? Enter yes or no: ");
            string brakeIn = Console.ReadLine();
            VehicleInit(yearIn, makeIn, modelIn, matIn, SetBrakes(brakeIn.ToLower()));
            Console.Write("Does this SUV have a hitch? Enter yes or no: ");
            string hitchIn = Console.ReadLine();
            Console.Write("How many rows of seats does this SUV have: ");
            int rowIn = int.Parse(Console.ReadLine());
            SUVInit((SetHitch(hitchIn.ToLower())),rowIn);

            Console.WriteLine("Building the SUV.");

        }

        public bool SetBrakes(string input)
        {
            if (input == "no") return false;
            else return true;
        }

        public bool SetHitch(string input)
        {
            if (input == "yes") return true;
            else return false;
        }

    }
}
