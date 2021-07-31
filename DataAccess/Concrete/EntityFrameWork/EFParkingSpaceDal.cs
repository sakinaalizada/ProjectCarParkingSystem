using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;


namespace DataAccess.EntityFrameWork.Concrete
{
    public class EFParkingSpaceDal : EFEntityRepositoryBase<ParkingSpace, CarParkingContext>, IParkingSpaceDal
    {

    }
}
