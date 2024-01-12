using System;

namespace W4_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car[] cars = new Car[0];
            string opr;
            do
            {
                Console.WriteLine("====MENU====\n");
                Console.WriteLine("1. Butun masinlara bax");
                Console.WriteLine("2. Masin elave et");
                Console.WriteLine("3. Masin sec ve sur");
                Console.WriteLine("0. Cix");

                
                Console.WriteLine("Emeliyyati daxil et: ");
                opr = Console.ReadLine();

                switch (opr)
                {
                    case "1":
                        ShowCars(cars);
                        break;
                    case "2":
                        AddCar(ref cars);
                        break;
                    case "3":
                        DriveCar(ref cars);
                        break;
                    case "0":
                        Console.WriteLine("Proqram Bitdi!");
                        break;
                    default:
                        break;
                }
            } while (opr != "0");


            //string fuelCapacityStr;
            //double fuelCapacity;
            //double millage = 0;
           

            //Console.WriteLine("Enter Brand: ");
            //string brand = Console.ReadLine();

            //Console.WriteLine("Enter Model: ");
            //string model = Console.ReadLine();

            //Console.WriteLine("Enter Fuel Capacity: ");

            //do
            //{
            //    fuelCapacityStr = Console.ReadLine();
            //} while (!double.TryParse(fuelCapacityStr, out fuelCapacity) || fuelCapacity < 0);

            //Car car = new Car(brand, model, fuelCapacity, millage);
            //car.ShowInfo();

            //string millageStr;


            //do
            //{
            //    Console.WriteLine("Enter KM: ");
            //    millageStr = Console.ReadLine();
            //} while (!double.TryParse(millageStr, out millage) || millage < 0);

            //car.Drive(millage);
            //car.ShowInfo();



        }
        static void AddCar(ref Car[] cars)
        {
            string fuelCapacityStr;
            double fuelCapacity;
            double millage = 0;
            Car car = new Car();
            Console.WriteLine("Enter Brand: ");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter Model: ");
            string model = Console.ReadLine();

            Console.WriteLine("Enter Fuel Capacity: ");
            do
            {
                fuelCapacityStr = Console.ReadLine();
            } while (!double.TryParse(fuelCapacityStr, out fuelCapacity) || fuelCapacity < 0);


            Array.Resize(ref cars, cars.Length + 1);
            cars[cars.Length - 1] = car;

            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == car)
                {
                    Console.WriteLine("Bu masin siyahida artiq var!");
                }

            }
            car = new Car(brand, model, fuelCapacity, millage);

        }

        static void ShowCars(Car[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i+1}.");
                cars[i].ShowInfo();
            }
        }

        static void DriveCar(ref Car[] cars)
        {
            ShowCars(cars);
            string indexStr;
            double millage = 0;

            Console.WriteLine("Surmek istediyin masinin sira nomresini daxil et: ");
            
            int sira;
            do
            {
                indexStr = Console.ReadLine();
            } while (!int.TryParse(indexStr, out sira) || sira < 1 || sira > cars.Length);

            string millageStr;


            do
            {
                Console.WriteLine("Enter KM: ");
                millageStr = Console.ReadLine();
            } while (!double.TryParse(millageStr, out millage) || millage < 0);

            cars[sira - 1].Drive(millage);
            
        }
    }
}
