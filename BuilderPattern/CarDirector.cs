using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DesignPatterns
{
    class CarDirector
    {
        public void ConstructCar(ICarBuilder builder)
        {
            builder.BuildMake();
            builder.BuildModel();
            builder.BuildYear();
            builder.BuildCost();
        }
    }
}
