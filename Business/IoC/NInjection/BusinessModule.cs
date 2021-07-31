using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.EntityFrameWork.Concrete;
using Ninject.Modules;

namespace Business.IoC.NInjection
{
    public class BusinessModule: NinjectModule
    {
        public override void Load()
        {
            Bind<ICarService>().To<CarManager>().InSingletonScope();
            Bind<IEmployeeService>().To<EmployeeManager>().InSingletonScope();
            Bind<IParkingSpaceService>().To<ParkingSpaceManager>().InSingletonScope();
            Bind<ICarDal>().To < EFCarDal>().InSingletonScope();
            Bind<IParkingSpaceDal>().To<EFParkingSpaceDal>().InSingletonScope();
            Bind<IEmployeeDal>().To<EFEmployeeDal>().InSingletonScope();
        }
    }
}
