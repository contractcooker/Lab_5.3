using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._3
{
    class CarLot
    {
        List<Car> inventory = new List<Car>();

        internal List<Car> Inventory { get => inventory; set => inventory = value; }

        public void AddCar(Car car)
        {
            Inventory.Add(car);
        }
        public void ListCar()
        {
            Console.WriteLine("   {0}{1,11}{2,10}{3,10}{4,17}","Make","Model","Year","Price","Mileage");            
            Console.WriteLine("----------------------------------------------------------------");
            for (int i = 0; i < Inventory.Count; i++)
            {
                Console.WriteLine($"{i+1}.{Inventory[i]}");

            }
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"{Inventory.Count + 1}. Add a car");
            Console.WriteLine($"{Inventory.Count + 2}. Quit");
            Console.WriteLine();
            //foreach (Car car in inventory)
            //{
            //    Console.WriteLine(car);
            //}
        }
        public void RemoveCar(int choice)
        {
            Inventory.Remove(Inventory[choice - 1]);
        }
    }

}
