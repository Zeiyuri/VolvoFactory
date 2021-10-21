using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBlueprints
{
    abstract class Blueprint
    {
        protected string VinNumber { get; init; }
        protected string LicensePlateNumber { get; init; }
        public string ModelName { get; init; }
        protected int NumberOfWheels { get; set; }
        protected string Color { get; init; }
        public int Price { get; init; }



    }
}
