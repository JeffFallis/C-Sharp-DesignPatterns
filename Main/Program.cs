using DesignPatterns.SingletonPattern;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            String designPattern = DetermineDesignPattern();

            RunDesignPattern(designPattern);

            StallProgram();
        }

        static string DetermineDesignPattern()
        {
            string designPattern;
            bool isIncorrectInput;
            do
            {
                designPattern = AskForDesignPattern();
                isIncorrectInput = IsCorrectDesignPattern(designPattern);

            } while (isIncorrectInput);

            return designPattern;
        }

        static string AskForDesignPattern()
        {
            Console.WriteLine("Which design pattern would you like to run?");
            Console.WriteLine("Builder or Singleton");
            return Console.ReadLine().ToLower();
        }

        static bool IsCorrectDesignPattern(string chosenDesignPattern)
        {
            if (chosenDesignPattern == "builder" || chosenDesignPattern == "singleton")
            {
                return false;
            }
            return true;
        }

        static void RunDesignPattern(string chosenDesignPattern)
        {
            if (chosenDesignPattern == "builder")
            {
                RunBuilderPattern();
            } else if (chosenDesignPattern == "singleton")
            {
                RunSingletonPattern();
            }
        }

        static void RunBuilderPattern()
        {
            Factory hyundaiFactory = new Factory("Hyundai");

            hyundaiFactory.BuildNewCar("accent");
            hyundaiFactory.BuildNewCar("elantra");
            hyundaiFactory.BuildNewCar("sonata");

            hyundaiFactory.PrintCars();
        }

        static void RunSingletonPattern()
        {
            EmployeeController1 controller1 = new EmployeeController1();
            EmployeeController2 controller2 = new EmployeeController2();

            Employee jeff = new Employee("Jeffrey", "Fallis", 1);
            Employee paloma = new Employee("Paloma", "Lieffring", 2);

            controller1.AddEmployee(jeff);
            controller2.AddEmployee(paloma);

            controller1.PrintEmployees();
            controller2.PrintEmployees();
        }

        static void StallProgram()
        {
            Console.WriteLine("\nEnter any key to continue...");
            Console.ReadLine();
        }
    }
}
