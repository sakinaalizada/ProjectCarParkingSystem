using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;


namespace DataAccess.EntityFrameWork.Concrete
{
    public class EFEmployeeDal : EFEntityRepositoryBase<Employee, CarParkingContext>, IEmployeeDal
    {

    }
}
