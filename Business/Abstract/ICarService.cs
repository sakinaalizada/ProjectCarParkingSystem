using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetAll(Expression<Func<Car, bool>> filter = null);
        List<Car> SearchByCarPlate(string text);
    }
}
