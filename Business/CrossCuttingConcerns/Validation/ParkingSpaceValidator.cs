using Entities.Concrete;
using FluentValidation;

namespace Business.CrossCuttingConcerns.Validation
{
    public class ParkingSpaceValidator: AbstractValidator<ParkingSpace>
    {
        public ParkingSpaceValidator()
        {
            RuleFor(m => m.ParkingSpaceId).NotEmpty();
            RuleFor(m => m.ParkingSpaceId).GreaterThan(0);
            RuleFor(m => m.ParkingSpaceAdress.Trim()).NotEmpty();
            RuleFor(m => m.TotalNumberParkingSpots).NotEmpty();
            RuleFor(m => m.TotalNumberParkingSpots).GreaterThan(0);
            RuleFor(m => m.ChargeForHour).NotEmpty();
        }
    }
}
