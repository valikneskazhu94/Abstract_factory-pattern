using ConsoleApp1.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Factories
{
    public abstract class CarFactory
    {
        public abstract FamilyCar CreateFamilyCar();
        public abstract SportsCar CreateSportsCar();
       

    }
}
