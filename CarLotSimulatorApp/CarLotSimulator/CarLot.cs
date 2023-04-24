using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot()
        {
        }
        public static int numberOfCars = 1;
        public List<Car> MyCarList { get; set; } = new List<Car>();
    }
}
