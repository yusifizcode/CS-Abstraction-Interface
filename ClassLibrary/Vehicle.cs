using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class Vehicle
    {
        public string Color;
        public string Brand;
        public int Millage;
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Color: {Color} | Brand: {Brand} | Millage: {Millage}");
        }
        public abstract void Drive();
    }
}
