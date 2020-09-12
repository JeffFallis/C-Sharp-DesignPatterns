using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class ElantraCarBuilder : ICarBuilder
    {
        private Car car = new Car();

        public void BuildMake()
        {
            car.Make = "Hyundai";
        }

        public void BuildModel()
        {
            car.Model = "Elantra";
        }

        public void BuildYear()
        {
            car.Year = 2020;
        }

        public void BuildCost()
        {
            car.Cost = 19000;
        }

        public Car GetCar()
        {
            return car;
        }
    }
}
