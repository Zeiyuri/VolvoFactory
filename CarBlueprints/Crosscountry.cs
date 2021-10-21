using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBlueprints
{
    class Crosscountry : Blueprint
    {
        private string _csEngineSound = "Bwrum Bwrum";
        public Crosscountry(string vinNumber, string licensePlateNumber, int price)
        {
            LicensePlateNumber = licensePlateNumber;
            VinNumber = vinNumber;
            ModelName = "XC60";
            Color = "White";
            NumberOfWheels = 4;
            Price = price;
            var Engine = new Engine(_csEngineSound);
            for (int i = 0; i < NumberOfWheels; i++)
            {
                new Wheel();
            }
        }
        public Crosscountry(string vinNumber, string licensePlateNumber, int price , string model, string color)
        {
            LicensePlateNumber = licensePlateNumber;
            VinNumber = vinNumber;
            ModelName = model;
            Color = color;
            NumberOfWheels = 4;
            Price = price;
            var Engine = new Engine(_csEngineSound);
            for (int i = 0; i < NumberOfWheels; i++)
            {
                new Wheel();
            }
        }
    }
}

