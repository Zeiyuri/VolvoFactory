using System;

namespace CarBlueprints
{
    class Program
    {
        static void Main(string[] args)
        {
            var myWarehouse = new Warehouse();
            myWarehouse.PrintInventory();
            Blueprint car1 = new Crosscountry("4Y1SL6888Z411439", "KPD723", 849000, "XC90", "Metallic Black");
            Blueprint car2 = new Sedan("4Y1SL54245Z411439", "JUU916", 300000, "S60", "Lime Green");
            myWarehouse.AddToInventory(car1);
            myWarehouse.AddToInventory(car2);
            myWarehouse.PrintInventory();
            myWarehouse.SortListByPrice();
            myWarehouse.PrintInventory();
            Console.WriteLine("");
            myWarehouse.SortListByName();
            myWarehouse.PrintInventory();
            
            
        }
    }
}
