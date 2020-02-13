using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._3
{
    class Car
    {
        string make;
        string model;
        int year;
        double price;


        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }

        public Car()
        {
            this.make = "make";
            this.model = "model";
            this.year = 2020;
            this.price = 0;
        }

        public Car(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public override string ToString()
        {
            return $" {make}{model,10}{year,10}{price,15:C}";
        }
    }
}
