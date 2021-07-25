using Entities.Abstract;
using System;


namespace Entities.Concrete
{
    public class Employee : IEntity
    {
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public decimal EmployeeSalary { get; set; }
        public int ParkingSpaceId { get; set; }

    }
}