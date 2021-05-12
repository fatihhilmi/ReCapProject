using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal iCarDal)
        {
            this._carDal = iCarDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice> 0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Araç eklenemedi");
            }
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int Id)
        {
            return _carDal.GetAll(p => p.BrandId == Id);
        }

        public List<Car> GetByColorId(int Id)
        {
            return _carDal.GetAll(c => c.ColorId == Id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
