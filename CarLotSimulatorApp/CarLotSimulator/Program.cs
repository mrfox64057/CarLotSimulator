using System;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var car1 = new Car();

            car1.Make = "Geo";
            car1.Model = "Tracker";
            car1.Year = 1994;
            car1.EngineNoise = "YEEEEE pup pup WEEEEEE badonk psh";
            car1.HonkNoise = "peet peet";
            car1.IsDriveable = false;
            car1.EngineNoise = "YEEEEE pup pup WEEEEEE badonk psh";
           

            var car2 = new Car()
            {
                Make = "Ferarri",
                Model = "250 GT",
                Year = 1962,
                EngineNoise = "heavenly orchestra",
                HonkNoise = "I'm rich",
                IsDriveable = true
            };
            

            var car3 = new Car("Lucid", "Air Dream Edition", 2023, true, "crickets chirping",
                "the future is now");

            car1.MakeEngineNoise();
            car1.MakeHonkNoise();
            car2.MakeHonkNoise();
            car2.MakeEngineNoise();
            car3.MakeEngineNoise();
            car3.MakeHonkNoise();

            var lot = new CarLot();
            lot.MyCarList.Add(car1);
            lot.MyCarList.Add(car2 );
            lot.MyCarList.Add(car3);



            foreach (var car in lot.MyCarList)
            {
                Console.WriteLine($"{car.EngineNoise}");
                Console.WriteLine($"{car.HonkNoise}");
                Console.WriteLine($"{car.Make}");
                Console.WriteLine($"{car.Year}");
                Console.WriteLine($"{car.Model}");
                Console.WriteLine();
                Console.WriteLine();
            }




            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }

        //public static void DisplayNoise(CarLotSimulator.Car car)
        //{
        //    Console.WriteLine($"{car1.Model}" );
        //}


    }
}
