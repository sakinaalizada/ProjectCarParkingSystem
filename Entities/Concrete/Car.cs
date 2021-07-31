using System;
using Entities.Abstract;
namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public string CarPlate { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public decimal TotalTime { get; set; }
        public decimal TotalCharge { get; set; }
        public string Status { get; set; }
        public int ParkingSpaceId { get; set; }
    }

}