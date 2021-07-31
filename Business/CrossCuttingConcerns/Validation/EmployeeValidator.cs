using Entities.Concrete;
using FluentValidation;

namespace Business.CrossCuttingConcerns.Validation
{
    public class EmployeeValidator: AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(m => m.EmployeeId).NotEmpty();
            RuleFor(m => m.EmployeeId).GreaterThan(0);
            RuleFor(m => m.ParkingSpaceId).NotEmpty();
            RuleFor(m => m.ParkingSpaceId).GreaterThan(0);
            RuleFor(m => m.EmployeeFirstName.Trim()).NotEmpty();
            RuleFor(m => m.EmployeeFirstName).MinimumLength(2);
            RuleFor(m => m.EmployeeLastName.Trim()).NotEmpty();
            RuleFor(m => m.EmployeeLastName).MinimumLength(3);
            RuleFor(m => m.EmployeeSalary).NotEmpty();
            RuleFor(m => m.EmployeeSalary).GreaterThan(0);


        }
    }
}
