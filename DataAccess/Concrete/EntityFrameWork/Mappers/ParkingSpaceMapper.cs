using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
