using System;
using System.Collections.Generic;
using System.Text;

namespace W4_Practice
{
    internal class Car:Vehicle
    {
        public Car()
        {

        }
        
        public Car(string brand, string model) : base(brand, model)
        {
            
        }
        public Car(string brand,string model, double fuelcapacity):base(brand,model)
        {
            this.FuelCapacity= fuelcapacity;
        }
        public Car(string brand, string model, double fuelcapacity, double millage) : base(brand, model)
        {
            this.FuelCapacity = fuelcapacity;
            this.Millage= millage;
        }

        public double FuelCapacity;
        public double Millage;

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {this.Brand}\nModel: {this.Model}\nFuel Capacity: {this.FuelCapacity}\nMillage: {this.Millage}");
        }

        public void Drive(double millage)
        {
            this.Millage += millage;
        }
    }
}
