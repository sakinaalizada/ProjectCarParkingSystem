using Business.Abstract;
using Business.CrossCuttingConcerns.Validation;
using DataAccess.Abstract;
using DataAccess.CrossCuttingConcerns.Validation;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;

        }
        public void Add(Car car)
        {
            ValidatorTool.Validate<Car>(car,new CarValidator());
            _carDal.Add(car);


        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();

        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _carDal.GetAll(filter);
        }

        public List<Car> SearchByCarPlate(string text)
        {
            return _carDal.GetAll(m => m.CarPlate.ToLower().Contains(text));
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}