using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class HyundaiFactory : Factory
    {
        public HyundaiFactory(String name) : base(name)
        {
            // Empty on purpose
        }

        public void BuildCar(ICarBuilder builder)
        {
            CarDirector.ConstructCar(builder);
        }
    }
}
