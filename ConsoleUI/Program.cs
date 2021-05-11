using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.Description);
            }

            carManager.Add(new Entities.Concrete.Car { BrandId = 1, DailyPrice = 0, Description = "hp", ModelYear = "2021", ColorId = 1 });


        }
    }
}
