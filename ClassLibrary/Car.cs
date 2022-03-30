using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car:Vehicle
    {
        public int FuelCapacity { get; set; }
        public int CurrentFuel { get; set; }
        public int FuelFor1km { get; set; }

        public override void Drive()
        {
            if (CurrentFuel>=Millage*FuelFor1km)
            {
                CurrentFuel-=FuelFor1km;
                Millage++;
            }
            else
            {
                Console.WriteLine("benzin azdi");
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Color: {Color} | Brand: {Brand} | Current fuel: {CurrentFuel} | millage: {Millage} | FuelFor1km: {FuelFor1km}");
        }

        public Car[] CarFilter(Car[] cars, int min, int max)
        {
            Car[] filteredCars = new Car[0];
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Millage>min && cars[i].Millage<max)
                {
                    Array.Resize(ref filteredCars, filteredCars.Length + 1);
                    filteredCars[filteredCars.Length-1] = cars[i];
                }
            }
            return filteredCars;
        }
    }
}
