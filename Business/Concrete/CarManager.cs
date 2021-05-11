using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
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

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p=>p.BrandId==id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p=>p.ColorId==id);
        }
    }
}
