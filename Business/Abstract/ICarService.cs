﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetByColorId(int colorId);
        IDataResult<Car> GetByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarDetails();

        IResult Add(Car car);
        //void Delete(Car car);
        //void Update(Car car);
    }
}
