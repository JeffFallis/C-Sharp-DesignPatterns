using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    internal interface ICarBuilder
    {
        public void BuildMake();

        public void BuildModel();

        public void BuildYear();

        public void BuildCost();

        public Car GetCar();
    }
}
