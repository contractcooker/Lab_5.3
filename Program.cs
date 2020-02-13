using System;

namespace Lab_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            CarLot carLot = new CarLot();
            carLot.AddCar(new Car("Lexus", "GS350", 2020, 50000));
            carLot.AddCar(new Car("Lexus", "LS450", 2020, 70000));
            carLot.AddCar(new UsedCar("Lexus", "GS350", 2013, 25000, 65000));

            while (flag)
            {                
                carLot.ListCar();
                Console.Write("Which car would you like? ");

                bool choice = int.TryParse(Console.ReadLine(), out int input);

                
                if (input <= carLot.Inventory.Count)
                {
                    Console.WriteLine(carLot.Inventory[input - 1]);
                    Console.Write("Would you like to purchase this fine vehicle? (y/n) ");
                    char selection = char.Parse(Console.ReadLine());
                    if ("Yy".Contains(selection))
                    {
                        carLot.Inventory.Remove(carLot.Inventory[input - 1]);
                        Console.WriteLine();
                    }
                }
                else if (input == carLot.Inventory.Count + 1)
                {
                    Console.Write("Make: ");
                    string make = Console.ReadLine();
                    Console.Write("Model: ");
                    string model = Console.ReadLine();
                    Console.Write("Year: ");
                    int year = int.Parse(Console.ReadLine());
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Mileage (-1 if new car): ");
                    double mileage = double.Parse(Console.ReadLine());
                    if (mileage == -1)
                    {
                        carLot.AddCar(new Car(make, model, year, price));
                    }
                    else
                    {
                        carLot.AddCar(new UsedCar(make, model, year, price, mileage));
                    }
                }
                else if (input == carLot.Inventory.Count + 2)
                {
                    flag = false;
                }
                
            }


        }
    }
}
