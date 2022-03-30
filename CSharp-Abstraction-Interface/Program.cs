using System;
using ClassLibrary;
namespace CSharp_Abstraction_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Elave etmek istediyiniz masin sayi:");
            int carCount = Convert.ToInt32(Console.ReadLine());
            Car[] cars = new Car[carCount];
            Car car = new Car();
            for (int i = 0; i < carCount; i++)
            {
                Console.WriteLine($"{i + 1}. masinin rengini yazin:");
                string color = Console.ReadLine();
                Console.WriteLine($"{i + 1}. masinin brandini yazin:");
                string brand = Console.ReadLine();
                Console.WriteLine($"{i + 1}. masinin millageni yazin:");
                int millage = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{i + 1}. masinin hazirki benzinini yazin:");
                int currentFuel = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{i + 1}. masinin 1 km ucun istifade edeceyi benzini yazin:");
                int fuelFor1Km = Convert.ToInt32(Console.ReadLine());
                car = new Car() { Color = color, Brand = brand, Millage = millage, CurrentFuel = currentFuel, FuelFor1km = fuelFor1Km };
                cars[i] = car;
            }

            car.Drive();

            Console.WriteLine("1. Masinlari millage-e gore filterle\n2.Butun masinlari goster\n3.Prosesi bitir");
            string answer = Console.ReadLine();

            if (answer == "1")
            {
                Console.WriteLine("Minimum millage yazin: ");
                int min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Maximum millage yazin: ");
                int max = Convert.ToInt32(Console.ReadLine());

                foreach (var item in car.CarFilter(cars, min, max))
                {
                    item.ShowInfo();
                }
            }
            else if (answer == "2")
            {
                foreach (var item in cars)
                {
                    item.ShowInfo();
                }
            }
            else { return; }
        }

    }
}
