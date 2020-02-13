using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._3
{
    class UsedCar : Car
    {
        double mileage;

        public UsedCar(string make, string model, int year, double price, double mileage) : base(make, model, year, price)
        {
            this.mileage = mileage;
        }

        public override string ToString()
        {
            return base.ToString() + $"{mileage,10} miles";
        }
    }
}
