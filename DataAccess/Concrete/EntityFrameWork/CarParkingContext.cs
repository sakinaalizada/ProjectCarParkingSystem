using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class CarParkingContext : DbContext
    {
        DbSet<Car> Cars { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<ParkingSpace> ParkingSpaces { get; set; }
    }
}
