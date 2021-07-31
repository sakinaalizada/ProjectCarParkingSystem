using Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Concrete.EntityFrameWork.Mappers
{
   public class ParkingSpaceMapper: EntityTypeConfiguration<ParkingSpace>
    {
        public ParkingSpaceMapper()
        {
            ToTable("ParkingSpaces");
            HasKey(m=>m.ParkingSpaceId);
            Property(m => m.ParkingSpaceId).HasColumnName("ParkingSpaceId");
            Property(m => m.ParkingSpaceAdress).HasColumnName("ParkingSpaceAdress");
            Property(m => m.TotalNumberParkingSpots).HasColumnName("TotalNumberParkingSpots");
            Property(m => m.ChargeForHour).HasColumnName("ChargeForHour");
        }
   }
}
