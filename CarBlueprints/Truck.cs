using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBlueprints
{
    class Truck : Blueprint
    {
        private string _truckEngineSound = "Bwrumbawrum";
        public Truck(string vinNumber, string licensePlateNumber, int price)
        {
            LicensePlateNumber = licensePlateNumber;
            VinNumber = vinNumber;
            ModelName = "FH16";
            Color = "White";
            NumberOfWheels = 4;
            Price = price;
            var Engine = new Engine(_truckEngineSound);
            for (int i = 0; i < NumberOfWheels; i++)
            {
                new Wheel();
            }
        }
        public Truck(string vinNumber, string licensePlateNumber, int price, string model, string color)
        {
            LicensePlateNumber = licensePlateNumber;
            VinNumber = vinNumber;
            ModelName = model;
            Color = color;
            NumberOfWheels = 4;
            Price = price;
            var Engine = new Engine(_truckEngineSound);
            for (int i = 0; i < NumberOfWheels; i++)
            {
                new Wheel();
            }
        }
    }
}
