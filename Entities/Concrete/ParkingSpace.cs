using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class ParkingSpace : IEntity
    {
        public int ParkingSpaceId { get; set; }
        public string ParkingSpaceAdress { get; set; }
        public int TotalNumberParkingSpots { get; set; }
        public decimal ChargeForHour { get; set; }

    }
}