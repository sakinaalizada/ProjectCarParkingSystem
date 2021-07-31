using Entities.Concrete;
using FluentValidation;

namespace Business.CrossCuttingConcerns.Validation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(m => m.CarId).NotEmpty();
            RuleFor(m => m.CarId).GreaterThan(0);
            RuleFor(m => m.CarPlate).NotEmpty();
            RuleFor(m => m.ArrivalTime).NotEmpty();
            RuleFor(m => m.DepartureTime).NotEmpty();
            RuleFor(m => m.ParkingSpaceId).NotEmpty();
            RuleFor(m => m.ParkingSpaceId).GreaterThan(0);

        }
    }
}
