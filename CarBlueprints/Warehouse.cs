using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBlueprints
{
    class Warehouse
    {
        public List<Blueprint> CarInventory;
        public Warehouse()
        {
            CarInventory = new List<Blueprint>()
            {
                new Truck("4Y1SL65848Z411439", "CDQ652",1500000),
                new Sedan("4Y1SL65848Z234539", "IPD999",500000),
                new Crosscountry("4Y1SL54218Z234539", "QSC781",800000),
                new ElectricCar("4Y1SL65848Q998539", "LKD001",700000),
                new Sedan("4Y1SL44428Z234539", "CDZ002",430000)
            };
        }
        public void PrintInventory()
        {
            Console.WriteLine("Car Inventory:");
            foreach (Blueprint item in CarInventory)
            {
                Console.WriteLine($"Model: {item.ModelName,-20} Price: {item.Price}");
            }
        }
        public void AddToInventory(Blueprint carToAdd)
        {
            CarInventory.Add(carToAdd);
        }
        public void SortListByPrice()
        {
            List<Blueprint> SortedList = CarInventory.OrderByDescending(obj => obj.Price).ToList();
            CarInventory = SortedList;

        }
        public void SortListByName()
        {
            List<Blueprint> SortedList = CarInventory.OrderBy(obj => obj.ModelName).ToList();
            CarInventory = SortedList;
        }

    }
}
