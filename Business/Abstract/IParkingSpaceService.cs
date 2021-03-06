using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IParkingSpaceService
    {
        void Add(ParkingSpace parkingSpace);
        void Update(ParkingSpace parkingSpace);
        void Delete(ParkingSpace parkingSpace);
        List<ParkingSpace> GetAll(Expression<Func<ParkingSpace, bool>> filter = null);
        decimal GetChargeForHourById(int id);
        ParkingSpace GetById(int id);
    }
}