using Business.Concrete;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //BrandTest();

            //ColorTest();

            UserTest();

        }
        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User 
            {
                FirstName="Fatih Hilmi",
                LastName="ÖZKAN",
                Email="fatihhilmi@gmail.com",
                Password="sfr"  
            });
            Console.WriteLine(Messages.UserAdded);

            
        }

        
          
        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetByColorId(2);
            if (result.Success==true)
            {
                
                    Console.WriteLine(result.Data.ColorName);
                
            }
            else
            {
                Console.WriteLine(result.Message);
            }
                
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetById(2);
 
            if (result.Success==true)
            {
                
                    Console.WriteLine(result.Data.BrandName);
                
            }
            else
            {
                Console.WriteLine(result.Message);
            }
                
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description + "/ "+car.BrandName + "/ "+ car.ColorName + "/ "+ car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            carManager.Add(new Car { BrandId = 1, DailyPrice = 0, Description = "hp", ModelYear = "2021", ColorId = 1 });
        }
    }
}
