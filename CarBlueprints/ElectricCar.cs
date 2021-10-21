using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBlueprints
{
    class ElectricCar : Blueprint
    {
        private string _ElectricEngineSound = "Me be Silent";
        public ElectricCar(string vinNumber, string licensePlateNumber, int price)
        {
            LicensePlateNumber = licensePlateNumber;
            VinNumber = vinNumber;
            ModelName = "V90";
            Color = "White";
            NumberOfWheels = 4;
            Price = price;
            var Engine = new Engine(_ElectricEngineSound);
            for (int i = 0; i < NumberOfWheels; i++)
            {
                new Wheel();
            }
        }
        public ElectricCar(string vinNumber, string licensePlateNumber, int price, string model, string color)
        {
            LicensePlateNumber = licensePlateNumber;
            VinNumber = vinNumber;
            ModelName = model;
            Color = color;
            NumberOfWheels = 4;
            Price = price;
            var Engine = new Engine(_ElectricEngineSound);
            for (int i = 0; i < NumberOfWheels; i++)
            {
                new Wheel();
            }
        }
    }
}

