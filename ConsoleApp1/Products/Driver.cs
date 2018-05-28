using ConsoleApp1.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Products
{
    public class Driver
    {
        FamilyCar _familyCar;
        SportsCar _sportsCar;
        public Driver(CarFactory carFactory)
        {
            _familyCar = carFactory.CreateFamilyCar();
            _sportsCar = carFactory.CreateSportsCar();
        }
        public void CompareSpeed()
        {
            Console.WriteLine("Speed compared!");
        }
    }
}
