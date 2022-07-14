using System;
using System.Collections.Generic;
//-----------------------------------------------------------------
//Car
//
// Name: David Zientara
// Date: 7-13-2022
// Comments: An exercise in classes (exercise 2)
// Added methods per the instructions
//-----------------------------------------------------------------
namespace CarLotSimulator
{
    class Carlot
    {
        public List<Car> carlist;

        public Carlot()
        {
            carlist = new List<Car>(); 
        }
    }
    class Car
    {

        public string Make { get; set; } 
        public string Model { get; set; }
        public string HonkNoise { get; set; }
        public enum ENoise { Quiet, Noisy, OK};
        public ENoise EngineNoise { get; set; }
        public int Year { get; set; }
        public bool IsDriveable { get; set; }

        public ENoise MakeEngineNoise() 
        {
            return EngineNoise;
        }
        public string MakeHonkNoise()
        {
            return HonkNoise;
        }
        // Visual Studio makes it super-easy to add a ctor w/ parameters:
        public Car(string make, string model, string honkNoise, ENoise engineNoise, int year, bool isDriveable)
        {
            Make = make;
            Model = model;
            HonkNoise = honkNoise;
            EngineNoise = engineNoise;
            Year = year;
            IsDriveable = isDriveable;
        }
        // Also add a ctor w/o parameters and reasonable default values:
        public Car()
        {
            Make = "Plymouth";
            Model = "Valiant";
            HonkNoise = "Beep";
            EngineNoise = Car.ENoise.OK;
            Year = 1980;
            IsDriveable = true;
        }
    }
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

            Car Golf = new Car();
            Car Festiva = new Car();
            Car GTO = new Car();

            Golf.Make = "Volkswagen";
            Golf.Model = "Golf";
            Golf.Year = 1992;
            Golf.EngineNoise = Car.ENoise.Noisy;
            Golf.HonkNoise = "Beep, beep";
            Festiva.Make = "Ford";
            Festiva.Model = "Festiva";
            Festiva.Year = 2005;
            Festiva.EngineNoise = Car.ENoise.OK;
            Festiva.HonkNoise = "Ah-ooo-gah";
            GTO.Make = "Pontiac";
            GTO.Model = "GTO";
            GTO.Year = 2018;
            GTO.EngineNoise = Car.ENoise.Quiet;
            GTO.HonkNoise = "Reeeeee";


            Console.WriteLine($" A {Golf.Year} {Golf.Make} {Golf.Model} makes the engine noise: {Golf.MakeEngineNoise()} ");
            Console.WriteLine($" A {Golf.Year} {Golf.Make} {Golf.Model} makes the honk noise: {Golf.MakeHonkNoise()} ");
            Console.WriteLine($" A {Festiva.Year} {Festiva.Make} {Festiva.Model} makes the engine noise: {Festiva.MakeEngineNoise()} ");
            Console.WriteLine($" A {Festiva.Year} {Festiva.Make} {Festiva.Model} makes the honk noise: {Festiva.MakeHonkNoise()} ");
            Console.WriteLine($" A {GTO.Year} {GTO.Make} {GTO.Model} makes the engine noise: {GTO.MakeEngineNoise()} ");
            Console.WriteLine($" A {GTO.Year} {GTO.Make} {GTO.Model} makes the honk noise: {GTO.MakeHonkNoise()} ");



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            Car GenericCar = new Car();
            Car Corvette = new Car("Chevy", "Corvette", "Beep beep", Car.ENoise.Quiet, 2022, true);
            Car Bluesmobile = new Car();
            Bluesmobile.Make = "Dodge";
            Bluesmobile.Model = "Monaco";
            Bluesmobile.Year = 1974;
            Bluesmobile.HonkNoise = "Ah-ooo-gah";
            Bluesmobile.EngineNoise = Car.ENoise.Noisy;
            Bluesmobile.IsDriveable = true;
            Console.WriteLine($" A {GenericCar.Year} {GenericCar.Make} {GenericCar.Model} makes the engine noise: {GenericCar.MakeEngineNoise()} ");
            Console.WriteLine($" A {Corvette.Year} {Corvette.Make} {Corvette.Model} makes the engine noise: {Corvette.MakeEngineNoise()} ");
            Console.WriteLine($" A {Bluesmobile.Year} {Bluesmobile.Make} {Bluesmobile.Model} makes the engine noise: {Bluesmobile.MakeEngineNoise()} ");




            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Carlot MyLot = new Carlot();
            MyLot.carlist.Add(Golf);
            MyLot.carlist.Add(Festiva);
            MyLot.carlist.Add(GTO);
            MyLot.carlist.Add(GenericCar);
            MyLot.carlist.Add(Corvette);
            MyLot.carlist.Add(Bluesmobile);

            Console.WriteLine("Added these cars to the lot:");
            foreach (Car car in MyLot.carlist)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }

        }
    }
}
