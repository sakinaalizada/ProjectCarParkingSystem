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
    public class ParkingSpaceManager : IParkingSpaceService
    {
        private IParkingSpaceDal _parkingSpaceDal;
        public ParkingSpaceManager(IParkingSpaceDal parkingSpaceDal)
        {
            _parkingSpaceDal = parkingSpaceDal;

        }
        public void Add(ParkingSpace parkingSpace)
        {
            ValidatorTool.Validate<ParkingSpace>(parkingSpace, new ParkingSpaceValidator());
            _parkingSpaceDal.Add(parkingSpace);


        }

        public void Delete(ParkingSpace parkingSpace)
        {
            _parkingSpaceDal.Delete(parkingSpace);

        }

        public List<ParkingSpace> GetAll()
        {
            return _parkingSpaceDal.GetAll();

        }

        public List<ParkingSpace> GetAll(Expression<Func<ParkingSpace, bool>> filter = null)
        {
            return _parkingSpaceDal.GetAll(filter);
        }

        public ParkingSpace GetById(int id)
        {
            return _parkingSpaceDal.Get(m => m.ParkingSpaceId == id);
        }

        public decimal GetChargeForHourById(int id)
        {
            return _parkingSpaceDal.Get(m => m.ParkingSpaceId == id).ChargeForHour;
        }

        public void Update(ParkingSpace parkingSpace)
        {
            _parkingSpaceDal.Update(parkingSpace);


        }
    }
}
