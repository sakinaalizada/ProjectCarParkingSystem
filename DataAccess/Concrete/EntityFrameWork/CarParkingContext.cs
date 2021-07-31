using DataAccess.Concrete.EntityFrameWork.Mappers;
using Entities.Concrete;
using System.Data.Entity;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class CarParkingContext : DbContext
    {
        DbSet<Car> Cars { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<ParkingSpace> ParkingSpaces { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CarMapper());
            modelBuilder.Configurations.Add(new EmployeeMapper());
            modelBuilder.Configurations.Add(new ParkingSpaceMapper());
        }
    }
   
}
