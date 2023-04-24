using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }
        public Car(string make, string model, int year, bool isDriveable, string engineNoise,
            string honkNoise)
        {
            Make = make;
            Model = model;
            Year = year;
            IsDriveable = isDriveable;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;

        }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public bool IsDriveable { get; set; }
        public string HonkNoise { get; set; }
        public string EngineNoise { get; set; }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"{HonkNoise}");
        }

        public void MakeEngineNoise()
        {
            Console.WriteLine($"{EngineNoise}");
        }


    }
    
}
