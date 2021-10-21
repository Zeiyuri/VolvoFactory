using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBlueprints
{
    class Engine
    {
        public string _engineSound;

        public Engine(string engineSound)
        {
            _engineSound = engineSound;
        }
        public void StartEngine()
        {
            Console.WriteLine($"Car starts with a {_engineSound}.");
        }
        public void StopEngine()
        {
            Console.WriteLine("The engine has turned off.");
        }
    }
}
