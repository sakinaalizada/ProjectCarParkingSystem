using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using System;
using System.Collections.Generic;


namespace DataAccess.EntityFrameWork.Concrete
{
    public class EFEmployeeDal : EFEntityRepositoryBase<Employee, CarParkingContext>, IEmployeeDal
    {

    }
}
