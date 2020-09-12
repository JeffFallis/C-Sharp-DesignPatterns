using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class AccentCarBuilder : ICarBuilder
    {
        private Car car = new Car();

        public void BuildMake()
        {
            car.Make = "Hyundai";
        }

        public void BuildModel()
        {
            car.Model = "Accent";
        }

        public void BuildYear()
        {
            car.Year = 2020;
        }

        public void BuildCost()
        {
            car.Cost = 16000;
        }

        public Car GetCar()
        {
            return car;
        }
    }
}
