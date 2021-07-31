using Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Concrete.EntityFrameWork.Mappers
{
   public class CarMapper: EntityTypeConfiguration<Car>
    {
        public CarMapper() 
        {
            ToTable("Cars");
            HasKey(m=>m.CarId);
            Property(m=>m.ArrivalTime).HasColumnName("ArrivalTime");
            Property(m=>m.DepartureTime).HasColumnName("DepartureTime");
            Property(m=>m.TotalTime).HasColumnName("TotalTime");
            Property(m=>m.CarId).HasColumnName("CarId");
            Property(m=>m.CarPlate).HasColumnName("CarPlate");
            Property(m=>m.TotalTime).HasColumnName("TotalTime");
            Property(m=>m.Status).HasColumnName("Status");
            Property(m=>m.ParkingSpaceId).HasColumnName("ParkingSpaceId");
        }

        
   }
}
