using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Factory
    {
        private string name;
        private double balance;
        private List<Car> cars;
        private CarDirector carDirector;
        private ICarBuilder builder;

        public string Name { get; set; }
        public double Balance { get; set; }
        public List<Car> Cars { get; set; }
        public CarDirector CarDirector { get; set; }
        public ICarBuilder Builder { get; set; }

        public Factory(string name)
        {
            Name = name;
            Balance = 0;
            Cars = new List<Car>();
            CarDirector = new CarDirector();
        }

        public void BuildNewCar(string builder)
        {
            Builder = FindBuilder(builder);
            CarDirector.ConstructCar(Builder);
            Cars.Add(Builder.GetCar());

        }

        private ICarBuilder FindBuilder(string builder)
        {
            builder = builder.ToUpper();
            if (builder == "ACCENT")
            {
                return new AccentCarBuilder();
            } else if (builder == "ELANTRA")
            {
                return new ElantraCarBuilder();
            } else if (builder == "SONATA")
            {
                return new SonataCarBuilder();
            }

            return null;
        }

        public void PrintCars()
        {
            Cars.ForEach(delegate (Car car)
            {
                Console.WriteLine("{0} {1} {2} - {3:C2}", car.Make, car.Model, car.Year, car.Cost);
            });
        }

        public void DepositMoney(double amount)
        {
            Balance += amount;
        }

        public void WithdrawMoney(double amount)
        {
            Balance -= amount;
        }
    }
}
