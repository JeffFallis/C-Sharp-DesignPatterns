using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class SonataCarBuilder : ICarBuilder
    {
        private Car car = new Car();

        public void BuildMake()
        {
            car.Make = "Hyundai";
        }

        public void BuildModel()
        {
            car.Model = "Sonata";
        }

        public void BuildYear()
        {
            car.Year = 2020;
        }

        public void BuildCost()
        {
            car.Cost = 24000;
        }

        public Car GetCar()
        {
            return car;
        }
    }
}
