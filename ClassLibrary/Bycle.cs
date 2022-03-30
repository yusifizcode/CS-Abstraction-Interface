using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Bycle : Vehicle
    {
        public override void Drive()
        {
            Millage++;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Color: {Color} | Brand: {Brand} | millage: {Millage}");
        }
    }
}
