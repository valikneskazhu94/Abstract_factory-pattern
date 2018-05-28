using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Products;

namespace ConsoleApp1.Factories
{
    public class AudiFactory:CarFactory
    {
        public override FamilyCar CreateFamilyCar()
        {
            return new AudiFamilyCar();
        }
        public override SportsCar CreateSportsCar()
        {
            return new AudiSportsCar();
        }
    }
}
