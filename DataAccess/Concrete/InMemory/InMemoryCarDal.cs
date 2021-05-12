using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car{BrandId=1, CarId=1,ColorId=1,ModelYear="2020",DailyPrice=1100,Description="Dizel"},
            new Car{BrandId=1, CarId=2,ColorId=1,ModelYear="2020",DailyPrice=900,Description="Benzin"},
            new Car{BrandId=2, CarId=3,ColorId=1,ModelYear="2020",DailyPrice=1000,Description="Manuel"},
            new Car{BrandId=3, CarId=4,ColorId=2,ModelYear="2021",DailyPrice=1300,Description="Otomatik"},
            new Car{BrandId=4, CarId=5,ColorId=2,ModelYear="2021",DailyPrice=1200,Description="Yarı Otomatik"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.First(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.First(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;


        }

        public List<Car> GetByColor(int colorId)
        {
           return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
