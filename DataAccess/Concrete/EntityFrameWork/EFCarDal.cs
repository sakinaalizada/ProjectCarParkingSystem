using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace DataAccess.EntityFrameWork.Concrete
{
    public class EFCarDal : EFEntityRepositoryBase<Car, CarParkingContext>, ICarDal
    {

    }
}
