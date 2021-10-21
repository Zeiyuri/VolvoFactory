using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBlueprints
{
    class Sedan : Blueprint 
    {
        private string _sedanEngineSound = "Wrom Wrom";
        public Sedan(string vinNumber, string licensePlateNumber, int price)
        {
            LicensePlateNumber = licensePlateNumber;
            VinNumber = vinNumber;
            ModelName = "S90";
            Color = "White";
            NumberOfWheels = 4;
            Price = price;
            var Engine = new Engine(_sedanEngineSound);
            for (int i = 0; i < NumberOfWheels; i++)
            {
                new Wheel();
            }
        }
        public Sedan(string vinNumber, string licensePlateNumber, int price, string model, string color)
        {
            LicensePlateNumber = licensePlateNumber;
            VinNumber = vinNumber;
            ModelName = model;
            Color = color;
            NumberOfWheels = 4;
            Price = price;
            var Engine = new Engine(_sedanEngineSound);
            for (int i = 0; i < NumberOfWheels; i++)
            {
                new Wheel();
            }
        }
    }
}
