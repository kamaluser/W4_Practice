using System;
using System.Collections.Generic;
using System.Text;

namespace W4_Practice
{
    internal class Vehicle
    {
        public Vehicle()
        {

        }
        public Vehicle(string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
        }

        public string Brand;
        public string Model;
    }
}
