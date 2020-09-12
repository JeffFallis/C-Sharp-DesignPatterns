using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Car
    {
        private double cost;
        private string make;
        private string model;
        private int year;

        public double Cost { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car()
        {
            Cost = 0;
            Make = "";
            Model = "";
            Year = 0;
        }

        public Car(double cost, string make, string model, int year)
        {
            Cost = cost;
            Make = make;
            Model = model;
            Year = year;
        }
    }
}
