using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork.Mappers
{
   public class EmployeeMapper: EntityTypeConfiguration<Employee>
    {
        public EmployeeMapper() 
        {
            ToTable("Employees");
            HasKey(m=>m.EmployeeId);
            Property(m => m.EmployeeId).HasColumnName("EmployeeId");
            Property(m => m.EmployeeFirstName).HasColumnName("EmployeeFirstName");
            Property(m => m.EmployeeLastName).HasColumnName("EmployeeLastName");
            Property(m => m.EmployeeSalary).HasColumnName("EmployeeSalary");
            Property(m => m.ParkingSpaceId).HasColumnName("ParkingSpaceId");

        }
    }
}
